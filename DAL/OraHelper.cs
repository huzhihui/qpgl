using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
namespace DAL
{
    public class OraHelper
    {
        private static readonly string connectionString = ConfigurationManager.AppSettings["qcgl"].ToString();

        #region 查询视图，返回DataTable
        /// <summary>
        /// 传入单条查询SQL语句，返回DataTable
        /// </summary>
        /// <param name="sql">查询sql语句</param>
        /// <param name="msg">接收异常信息</param>c
        /// <returns>DataTable</returns>
        public DataTable getTable(String sql,ref String msg)
        {
            DataTable dt = null;
            try {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand _cmd = new OracleCommand())
                    {
                        _conn.Open();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = sql;
                        OracleDataAdapter oraDa = new OracleDataAdapter(_cmd);
                        oraDa.Fill(dt);
                    }
                }
            }
            catch(Exception e)
            {
                msg = e.Message;
            }
            return dt;
        }

        /// <summary>
        /// 传入存储过程名称
        /// </summary>
        /// <param name="procedureName">存储过程名</param>
        /// <param name="msg">接收异常信息</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns></returns>
        public DataTable getTable(String procedureName,ref String msg,params OracleParameter[] parameters)
        {
            DataTable dt = null;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand _cmd = new OracleCommand())
                    {
                        _conn.Open();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.CommandText = procedureName;
                        _cmd.Parameters.AddRange(parameters);

                        OracleDataAdapter oraDa = new OracleDataAdapter(_cmd);
                        oraDa.Fill(dt);
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return dt;
        }

        /// <summary>
        /// 传入存储过程名称
        /// </summary>
        /// <param name="procedureName">存储过程名</param>
        /// <param name="msg">接收异常信息</param>
        /// <returns>DataTable</returns>
        public DataTable getTableNoParameters(String procedureName, ref String msg)
        {
            DataTable dt = null;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    using (OracleCommand _cmd = new OracleCommand())
                    {
                        _conn.Open();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.CommandText = procedureName;
                        
                        OracleDataAdapter oraDa = new OracleDataAdapter(_cmd);
                        oraDa.Fill(dt);
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return dt;
        }

        /// <summary>
        /// 出入不包含连接的Command命令，返回DataTable
        /// </summary>
        /// <param name="_cmd">Command对象</param>
        /// <param name="msg">接收异常信息</param>
        /// <returns>DataTable</returns>
        public DataTable getTable(OracleCommand _cmd,ref String msg)
        {
            DataTable dt = null;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    _conn.Open();
                    _cmd.Connection = _conn;
                    OracleDataAdapter oraDa = new OracleDataAdapter(_cmd);

                    oraDa.Fill(dt);
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return dt;
        }
        #endregion

        #region 执行单条DML语句，返回影响行数
        /// <summary>
        /// 传入单条DML的SQL语句，返回影响行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="msg">接收异常信息</param>
        /// <returns>int</returns>
        public int executeNonQuery(String sql, ref String msg)
        {
            int n = 0;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    _conn.Open();
                    using (OracleCommand _cmd = new OracleCommand(sql, _conn))
                    {
                        n = _cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return n;
        }

        /// <summary>
        /// 传入单个执行DML的存储过程，返回影响行数
        /// </summary>
        /// <param name="procedureName">存储过程名</param>
        /// <param name="msg">接收异常信息</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>int</returns>
        public int executeNonQuery(String procedureName, ref String msg,params OracleParameter[] parameters)
        {
            int n = 0;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    _conn.Open();
                    using (OracleCommand _cmd = new OracleCommand())
                    {
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.CommandText = procedureName;
                        _cmd.Parameters.AddRange(parameters);

                        n = _cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return n;
        }

        /// <summary>
        /// 传入单个执行DML的存储过程，返回影响行数
        /// </summary>
        /// <param name="procedureName">存储过程名</param>
        /// <param name="msg">接收异常信息</param>
        /// <returns></returns>
        public int executeNonQueryNoParameters(String procedureName, ref String msg)
        {
            int n = 0;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    _conn.Open();
                    using (OracleCommand _cmd = new OracleCommand())
                    {
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.StoredProcedure;
                        _cmd.CommandText = procedureName;

                        n = _cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return n;
        }

        /// <summary>
        /// 传入Command包含单个执行DML的存储过程，返回影响行数
        /// </summary>
        /// <param name="_cmd">Command对象</param>
        /// <param name="msg">接收异常信息</param>
        /// <returns>int</returns>
        public int executeNonQuery(OracleCommand _cmd, ref String msg)
        {
            int n = 0;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    _conn.Open();
                    _cmd.Connection = _conn;
                    n = _cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return n;
        }
        #endregion

        #region 传入Command集合进行事务执行
        /// <summary>
        /// 传入DML语句Command集合，进行事务执行，允许存在更新数为零的语句，成功返回1，失败为0
        /// </summary>
        /// <param name="msg">接收异常信息</param>
        /// <param name="_cmds">Command集合</param>
        /// <returns></returns>
        public int executeNonQueryTansaction(ref String msg,params OracleCommand[] _cmds)
        {
            int n = 0;
            OracleTransaction trans = null;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    _conn.Open();
                    trans = _conn.BeginTransaction();
                    foreach(OracleCommand _cmd in _cmds)
                    {
                        _cmd.Connection = _conn;
                        _cmd.Transaction = trans;
                        n = _cmd.ExecuteNonQuery();
                    }
                    return 1;
                }
            }catch(Exception e)
            {
                if(trans != null)
                {
                    trans.Rollback();
                }
                msg = e.Message;
                return 0;
            }
        }

        /// <summary>
        /// 传入DML语句Command集合，进行事务执行,不允许存在更新数为零的语句，成功返回1，失败为0
        /// </summary>
        /// <param name="msg">接收异常信息</param>
        /// <param name="_cmds">Command集合</param>
        /// <returns>int</returns>
        public int executeNonQueryTansactionAll(ref String msg, params OracleCommand[] _cmds)
        {
            int n = 0;
            OracleTransaction trans = null;
            try
            {
                using (OracleConnection _conn = new OracleConnection(connectionString))
                {
                    _conn.Open();
                    trans = _conn.BeginTransaction();
                    foreach (OracleCommand _cmd in _cmds)
                    {
                        _cmd.Connection = _conn;
                        _cmd.Transaction = trans;
                        n = _cmd.ExecuteNonQuery();
                        if (n < 1)
                        {
                            throw new Exception("不允许存在更新数为零");
                        }
                    }
                    return 1;
                }
            }
            catch (Exception e)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                msg = e.Message;
                return 0;
            }
        }
        #endregion
    }
}
