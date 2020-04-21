﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Models;
using Common;
using DBUtility;

namespace DAL
{
    /// <summary>
    /// About the operation method class of borrowing books
    /// </summary>
    public class BorrowBookServices
    {
        //Determine if a member has borrowed a book
        public bool IsBorrowedBook(string memberId)
        {
            //Preparing SQL statements
            string sql = "Select BorrowId from BorrowBook Where MemberId=@MemberId";

            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MemberId",memberId),
            };

            //Start execution and return value
            try
            {
                if (SQLHelper.GetOneResult(sql, para) == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get a MemberId
        public string BuildBorrowId()
        {
            //Get server time converted to 14-bit characters
            string borrowId = SQLHelper.GetServerTime().ToString("yyyyMMddHHmmss");
            //Generate 2-bit random numbers
            Random objRandom = new Random();
            borrowId += objRandom.Next(0, 100).ToString("00");
            //Return memberId 
            return 'B' + borrowId;
            
        }

        //Add a BorrowBoo to see the record
        public int AddBorrowBook(BorrowBook objBorrowBook)
        {
            //Preparing SQL statements
            string sql = "Insert into BorrowBook(BorrowId,MemberId,BorrowedNum,OverdueNum) Values(@BorrowId,@MemberId,@BorrowedNum,@OverdueNum)";
            //Prepare parameters
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@BorrowId",objBorrowBook.BorrowId),
                new SqlParameter("@MemberId",objBorrowBook.MemberId),
                new SqlParameter("@BorrowedNum",objBorrowBook.BorrowedNum),
                new SqlParameter("@OverdueNum",objBorrowBook.OverdueNum),
            };

            //Execute and submit
            try
            {
                return SQLHelper.Update(sql,para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get borrowNum based on memeberId
        public int GetBorrowedNumByMemberId(string memberId)
        {
            //Preparing SQL statements
            string sql = "select BorrowedNum from BorrowBook Where MemberId=@MemberId";
            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MemberId",memberId),
            };
            //Execute and return
            try
            {
                return Convert.ToInt32(SQLHelper.GetOneResult(sql, para));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get borrowId based on memberId 
        public string GetBorrowIdByMemberId(string memberId)
        {
            //Preparing SQL statements
            string sql = "select BorrowId from BorrowBook Where MemberId=@MemberId";
            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MemberId",memberId),
            };
            //Execute and return
            try
            {
                return SQLHelper.GetOneResult(sql, para).ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Update the number of BorrowbookNum and overdue
        public int UpdateBorrowedNumAndOverdue(string borrowId, int borrowedNum, int overdueNum)
        {
            //Preparing SQL statements
            string sql = "Update BorrowBook Set BorrowedNum=@BorrowedNum ,OverdueNum=@OverdueNum where BorrowId=@BorrowId";
            //Preparing parameters in SQL statements
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@BorrowId",borrowId),
                new SqlParameter("@BorrowedNum",borrowedNum),
                new SqlParameter("@OverdueNum",overdueNum),
            };
            //Execute and return
            try
            {
                return SQLHelper.Update(sql,para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Get borrowBook based on borrowId 
        public BorrowBook GetBorrowBookByBorrowId(string borrowId)
        {
            //Preparing SQL statements
            string sql = "Select BorrowId,MemberId,BorrowedNum,OverdueNum from BorrowBook Where BorrowId=@BorrowId";
            //Prepare parameters
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@BorrowId",borrowId),

            };

            //Read
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql,para);
                if (!objReader.HasRows) return null;
                BorrowBook objBorrowBook = new BorrowBook();
                if (objReader.Read())
                {
                    objBorrowBook = new BorrowBook()
                    {
                        BorrowId=objReader["BorrowId"].ToString(),
                        MemberId=objReader["MemberId"].ToString(),
                        BorrowedNum=Convert.ToInt32(objReader["BorrowedNum"]),
                        OverdueNum = Convert.ToInt32(objReader["OverdueNum"]),
                    };
                }
                //Close Read
                objReader.Close();
                //return
                return objBorrowBook;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Submit a library information
        public bool CommitBorrowBook(List<Book> objList,string borrowId,DateTime borrowDate,DateTime lastReturnDate)
        {
            //Define a List to store all executed SQL
            List<string> sqlList = new List<string>();

            //Define string Storage single SQL
            string sql = string.Empty;
            
            foreach (Book currentBook in objList)
            {
                //Insert book information into the BorrowDetail
                sql = "Insert into BorrowBookDetail ( BorrowId, BookId, BorrowDate, LastReturnDate, IsReturn, IsOverdue, IsHandleOverdueorLost, ReturnDate ) ";
                sql += " values ('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}')";
                sql = string.Format(sql, borrowId, currentBook.BookId, borrowDate, lastReturnDate, 0, 0, 0, null);
                //add to List
                sqlList.Add(sql);

                //Change the inventory of the corresponding book
                sql = string.Empty;
                sql = "Update Book Set InventoryNum=InventoryNum-1 Where BookId='{0}'";
                sql = string.Format(sql, currentBook.BookId);
                //add to List
                sqlList.Add(sql);

            }

            //Change the number of books borrowed in BorrowBook
            sql = string.Empty;
            sql = "Update BorrowBook Set BorrowedNum=BorrowedNum+{0} Where borrowId='{1}'";
            sql = string.Format(sql,objList.Count,borrowId);
            //add to List
            sqlList.Add(sql);


            //Submit
            try
            {
                return SQLHelper.UpdateByTransaction(sqlList);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
