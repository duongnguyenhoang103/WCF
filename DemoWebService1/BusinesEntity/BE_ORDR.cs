using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.Services;


namespace BusinesEntity
{
  public   class BE_ORDR
    {
//      DataConnect kn = new DataConnect();

//      DataTable dt;

//      [WebMethod]
//      public void addORDR(BO_ORDR obj)
//      {
//          try
//          {
//              string sql = @"INSERT INTO ORDR (DocEntry, DocNum, CardCode,CardName,CntctCode,DocStatus,TaxDate,DocDueDate,DocDate,Comments,DiscPrcnt,VatSum,DocTotal,DocCur,DocRate, NumAtCard, Series,CANCELED) ";
//              sql += " VALUES ('" + obj.DocEntry + "','" + obj.DocNum + "','" + obj.CardCode + "','" + obj.CardName + "','" + obj.CntctCode + "','" + obj.DocStatus + "','" + obj.TaxDate
//                                  + "','" + obj.DocDueDate + "', '" + obj.DocDate + "','" + obj.Comments + "','" + obj.DiscPrcnt + "','" + obj.VatSum
//                                  + "','" + obj.DocTotal + "','" + obj.DocCur + "','" + obj.DocRate + "', ' ', ' ' , ' ')";
//              kn.ExcuteNonQuery(sql);
//          }
//          catch (Exception)
//          {

//              throw;
//          }
//      }

//      [WebMethod]
//      public void updateORDR(BO_ORDR obj)
//      {
//          try
//          {

//              string sql = @"Update ORDR 
//                                         SET DocEntry ='" + obj.DocEntry + "', DocNum ='" + obj.DocNum + "', CardCode='" + obj.CardCode + "', CardName='" + obj.CardName
//                                            + "',CntctCode ='" + obj.CntctCode + "', DocStatus = '" + obj.DocStatus + "',TaxDate = '" + obj.TaxDate + "',DocDueDate='" + obj.DocDueDate + "',DocDate='" + obj.DocDate
//                                            + "',Comments='" + obj.Comments + "',DiscPrcnt='" + obj.DiscPrcnt + "',VatSum='" + obj.VatSum + "',DocTotal='" + obj.DocTotal + "',DocCur='" + obj.DocCur + "',DocRate='" + obj.DocRate
//                                            + "', NumAtCard = ' ', Series = ' ' ,CANCELED= ' ' ";
//              sql += " WHERE DocEntry = '" + obj.DocEntry + "' ";
//              kn.ExcuteNonQuery(sql);
//          }
//          catch (Exception)
//          {

//              throw;
//          }
//      }

//      [WebMethod]
//      public void deleteORDR(int keyDocEntry)
//      {
//          string sql = " DELETE RDR1 WHERE DocEntry = '" + keyDocEntry + "' "
//                      + " delete ORDR where DocEntry = '" + keyDocEntry + "'";

//          kn.ExcuteNonQuery(sql);
//      }

//      [WebMethod]
//      public DataTable ShowORDR()
//      {
//          string sql = "select * from ORDR";
//          return kn.GetTable(sql);
//      }

//      [WebMethod]
//      public DataTable searchByDate(string key1, string key2)
//      {
//          string sql = "select * from ORDR where ORDR.DocDate between '" + key1 + "' and '" + key2 + "'";
//          dt = kn.GetTable(sql);
//          return dt;
//      }

      
//      // tim kiem theo chi so No of Trans.
//      [WebMethod]
//      public DataTable searchByNoOfTrans(string noOfTrans)
//      {
//          string sql = "select * from ORDR where DocNum like '%" + noOfTrans + "%'";
//          return kn.GetTable(sql);

//      }

//      // tim kiem trang thai Document Status.
//      [WebMethod]
//      public DataTable searchDocument(string status, string cardName)
//      {
//          //            string sql = @"SELECT * 
//          //                            FROM ORDR 
//          //                            WHERE 1=1 ";
//          //            if (!string.IsNullOrEmpty(status))
//          //            {
//          //                sql += " AND DocStatus = '" + status + "'";
//          //            }
//          //            if (!string.IsNullOrEmpty(cardName))
//          //            {
//          //                sql += " AND Cardname like '%" + cardName + "%'";
//          //            }
//          //           // if(!string.IsNullOrEmpty(string ))     
//          //            dt = kn.GetTable(sql);
//          //            return dt;
//          string sql = "select * from ORDR where DocStatus =  '" + status + "' and CardName like N'%" + cardName + "%' ";
//          return kn.GetTable(sql);
//      }

//      [WebMethod]
//      public DataTable searchByDateAndStatus(string fdate, string tdate, string status)
//      {
//          string sql = "select * from ORDR where DocDate  between '" + fdate + "' and '" + tdate + "' and DocStatus like '%" + status + "%'";
//          return kn.GetTable(sql);
//      }

//      [WebMethod]
//      public DataTable searchByNoOfTranAndBTrans(string noOfTran, string bTrans)
//      {
//          string sql = " select * from ORDR where DocNum like '%" + noOfTran + "%' and CardName like '%" + bTrans + "%' ";
//          return kn.GetTable(sql);
//      }

//      // tim kiem theo ten cong ty Business Partner.
//      [WebMethod]
//      public DataTable searchByBTrans(string buTrans)
//      {
//          string sql = "select * from ORDR where CardName like '%" + buTrans + "%' ";
//          return kn.GetTable(sql);

//      }

//      [WebMethod]
//      public bool CheckDoc(int docentry)
//      {
//          string sql = "SELECT * FROM ORDR WHERE Docentry= " + docentry;
//          dt = kn.GetTable(sql);
//          BO_ORDR document = new BO_ORDR();
//          if (dt != null && dt.Rows.Count > 0)
//          {
//              return true;
//          }
//          return false;

//      }

//      [WebMethod]
//      public bool CheckExists(string idDocNum)
//      {
//          if (kn.CheckExistValue("ORDR", "DocNum", idDocNum ))
//              return true;
//          return false;
//      }
   }
}
