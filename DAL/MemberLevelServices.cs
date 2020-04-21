﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Models;
using DBUtility;

namespace DAL
{
    /// <summary>
    /// Operation Class of Membership level
    /// </summary>
    public class MemberLevelServices
    {
        //Get all Membership level information
        public List<MemberLevel> GetMemberLevel()
        {
            //SQL Statement to prepare query
            string sql = "Select LevelId,LevelName,LevelMonths,MaxBorrowNum,MaxBorrowDays,Deposit from MemberLevel ";
            //Execution and return values
            try
            {
                //Receive SqlDataReader type
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                //Determine if it is empty
                if (!objReader.HasRows) return null;
                //If it is not empty, it is stored <MemberLeveL>in</MemberLeveL> the list
                List<MemberLevel> objList = new List<MemberLevel>();
                //read
                while (objReader.Read())
                {
                    objList.Add(
                        new MemberLevel()
                        {
                            LevelId=Convert.ToInt32(objReader["LevelId"]),
                            LevelName=objReader["LevelName"].ToString(),
                            LevelMonths=Convert.ToInt32(objReader["LevelMonths"]),
                            MaxBorrowNum=Convert.ToInt32(objReader["MaxBorrowNum"]),
                            MaxBorrowDays=Convert.ToInt32(objReader["MaxBorrowDays"]),
                            Deposit=Convert.ToDouble(objReader["Deposit"]),
                        }
                        );
                }
                //Close read
                objReader.Close();
                //Return value
                return objList;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //Go back to all information about the membership level by name
        public MemberLevel GetMemberLevelByName(string levelName)
        {

            //SQL Statement to prepare query
            string sql = "Select LevelId,LevelName,LevelMonths,MaxBorrowNum,MaxBorrowDays,Deposit from MemberLevel Where LevelName=@LevelName ";
            //Provide parameters in a statement
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@LevelName",levelName),
            };
            //Execution and return values
            try
            {
                //Receive SqlDataReader type
                SqlDataReader objReader = SQLHelper.GetReader(sql,para);
                //Determine if it is empty
                if (!objReader.HasRows) return null;
                //If it is not empty, it is stored <MemberLeveL>in</MemberLeveL> the list
                MemberLevel objLevel = new MemberLevel();
                //read
                while (objReader.Read())
                {
                    objLevel = new MemberLevel()
                    {
                        LevelId = Convert.ToInt32(objReader["LevelId"]),
                        LevelName = objReader["LevelName"].ToString(),
                        LevelMonths = Convert.ToInt32(objReader["LevelMonths"]),
                        MaxBorrowNum = Convert.ToInt32(objReader["MaxBorrowNum"]),
                        MaxBorrowDays = Convert.ToInt32(objReader["MaxBorrowDays"]),
                        Deposit = Convert.ToDouble(objReader["Deposit"]),
                    };
                }
                //Close read
                objReader.Close();
                //Return value
                return objLevel;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //Generate a level number
        public string BuildNewLevelId()
        {

            //SQL Statement to prepare query
            string sql = "Select Top 1 LevelId from MemberLevel Order By LevelId DESC ";

            //Execution and return values
            try
            {
                object obj = SQLHelper.GetOneResult(sql);
                if (obj == null) return "1";
                else
                {
                    return (Convert.ToInt32(obj) + 1).ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Verify that the membership category name exists
        public bool IsExistLevelName(string levelName)
        {
            //Preparing SQL statements
            string sql = "Select LevelId from MemberLevel where LevelName=@LevelName ";
         
            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LevelName",levelName),
            };
            //Submit
            try
            {
                if (SQLHelper.GetOneResult(sql, para) == null) return false;
                else return true;

            }
            catch ( Exception ex)
            {

                throw ex;
            }
        }

        //Obtain membership name based on membership number
        public string GetNameById(int levelId)
        {
            //Preparing SQL statements
            string sql = "Select LevelName from MemberLevel where LevelId=@LevelId";
            //Prepare parameters
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LevelId",levelId),

            };

            //execution
            try
            {
                return SQLHelper.GetOneResult(sql, para).ToString(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Gets the expiration month for the appropriate level
        public int GetMonthsById(int levelId)
        {
            //Preparing SQL statements
            string sql = "Select LevelMonths from MemberLevel where LevelId=@LevelId";
            //Prepare parameters
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LevelId",levelId),

            };

            //execution
            try
            {
                return Convert.ToInt32(SQLHelper.GetOneResult(sql, para));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Obtain a member's loan validity period 
        public int GetMaxBorrowDays(int levelId)
        {
            //Preparing SQL statements
            string sql = "Select MaxBorrowDays from MemberLevel where LevelId=@LevelId";
            //Prepare parameters
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LevelId",levelId),

            };

            //execution
            try
            {
                return Convert.ToInt32(SQLHelper.GetOneResult(sql, para));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Obtain a member deposit based on membership number
        public double GetDepositById(int levelId)
        {
            //Preparing SQL statements
            string sql = "Select Deposit from MemberLevel where LevelId=@LevelId";
            //Prepare parameters
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LevelId",levelId),

            };

            //execution
            try
            {
                return Convert.ToDouble(SQLHelper.GetOneResult(sql, para));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get a List of membership levels
        public List<MemberLevel> GetLevelList()
        {
            //Preparing SQL statements
            string sql = "Select LevelId,LevelName from MemberLevel";

            //execution
            try
            {
                //SqlDataReader Receive data
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                //Determine if it is empty
                if (!objReader.HasRows) return null;
                //Define List
                List<MemberLevel> objList = new List<MemberLevel>();
                //read
                while (objReader.Read())
                {
                    objList.Add(
                        new MemberLevel()
                        {
                            LevelId=Convert.ToInt32(objReader["LevelId"]),
                            LevelName=objReader["LevelName"].ToString(),
                        }
                        );
                }
                //Close read
                objReader.Close();
                //Return
                return objList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get the biggest book to borrow books through Levelid
        public int GetMaxBorrowNumById(int levelId)
        {
            //Preparing SQL statements
            string sql = "Select MaxBorrowNum from MemberLevel where LevelId=@LevelId";
            //Prepare parameters
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LevelId",levelId),

            };

            //execution
            try
            {
                return Convert.ToInt32(SQLHelper.GetOneResult(sql, para));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Add a Membership Level
        public int AddMemberLevel(MemberLevel objMemberLevel)
        {
            //Preparing SQL statements
            string sql = "Insert into MemberLevel(LevelId, LevelName, LevelMonths, MaxBorrowNum, MaxBorrowDays, Deposit) ";
            sql += " Values(@LevelId, @LevelName, @LevelMonths, @MaxBorrowNum, @MaxBorrowDays, @Deposit)";
            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@LevelId",objMemberLevel.LevelId),
                new SqlParameter("@LevelName",objMemberLevel.LevelName),
                new SqlParameter("@LevelMonths",objMemberLevel.LevelMonths),
                new SqlParameter("@MaxBorrowNum",objMemberLevel.MaxBorrowNum),
                new SqlParameter("@MaxBorrowDays",objMemberLevel.MaxBorrowDays),
                new SqlParameter("@Deposit",objMemberLevel.Deposit),
            };
            //Submit
            try
            {
                return SQLHelper.Update(sql,para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Modify Membership Level
        public int UpdateMemberLevel(MemberLevel objMemberLevel)
        {
            //Preparing SQL statements
            string sql = "Update MemberLevel Set LevelMonths=@LevelMonths,MaxBorrowNum=@MaxBorrowNum,MaxBorrowDays=@MaxBorrowDays,Deposit=@Deposit Where LevelId=@LevelId";
         
            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LevelId",objMemberLevel.LevelId),
                new SqlParameter("@LevelMonths",objMemberLevel.LevelMonths),
                new SqlParameter("@MaxBorrowNum",objMemberLevel.MaxBorrowNum),
                new SqlParameter("@MaxBorrowDays",objMemberLevel.MaxBorrowDays),
                new SqlParameter("@Deposit",objMemberLevel.Deposit),
            };
            //Submit
            try
            {
                return SQLHelper.Update(sql, para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Delete Membership Level
        public int DeleteMemberLevel(string levelName)
        {
            //Preparing SQL statements
            string sql = "Delete from MemberLevel where LevelName=@LevelName";

            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@LevelName",levelName),
            };
            //Submit
            try
            {
                return SQLHelper.Update(sql, para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

