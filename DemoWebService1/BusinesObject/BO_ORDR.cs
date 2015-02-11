using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BusinesObject
{
    [DataContract]
   public  class BO_ORDR
    {
        [DataMember]
        public int DocEntry { get; set; }

        [DataMember]
        public int DocNum { get; set; }

        [DataMember]
        public string DocType { get; set; }

        [DataMember]
        public string CANCELED { get; set; }

        [DataMember]
        public string Handwrtten { get; set; }

        [DataMember]
        public string Printed { get; set; }

        [DataMember]
        public string DocStatus { get; set; }

        [DataMember]
        public string ObjType { get; set; }

        [DataMember]
        public DateTime DocDate { get; set; }

        [DataMember]
        public DateTime DocDueDate { get; set; }

        [DataMember]
        public string CardCode { get; set; }

        [DataMember]
        public string CardName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string NumAtCard { get; set; }

        [DataMember]
        public double VatSum { get; set; }

        [DataMember]
        public double VatSumFC { get; set; }

        [DataMember]
        public double DiscPrcnt { get; set; }

        [DataMember]
        public double DiscSum { get; set; }

        [DataMember]
        public double DiscSumFC { get; set; }

        [DataMember]
        public string DocCur { get; set; }

        [DataMember]
        public double DocRate { get; set; }

        [DataMember]
        public double DocTotal { get; set; }

        [DataMember]
        public double DocTotalFC { get; set; }

        [DataMember]
        public double PaidToDate { get; set; }

        [DataMember]
        public double PaidFC { get; set; }

       [DataMember]
        public double GrosProfit { get; set; }

        [DataMember]
        public double GrosProfFC { get; set; }

        [DataMember]
        public string Ref1 { get; set; }

        [DataMember]
        public string Ref2 { get; set; }

        [DataMember]
        public string Comments { get; set; }

        [DataMember]
        public string JrnlMemo { get; set; }

        [DataMember]
        public int TransId { get; set; }

        [DataMember]
        public int ReceiptNum { get; set; }

        [DataMember]
        public int GroupNum { get; set; }

        [DataMember]
        public DateTime DocTime { get; set; }

        [DataMember]
        public int SlpCode { get; set; }

        [DataMember]
        public int TrnspCode { get; set; }

        [DataMember]
        public int CntctCode { get; set; }

        [DataMember]
        public double VatSumSy { get; set; }

        [DataMember]
        public double DiscSumSy { get; set; }

        [DataMember]
        public double DocTotalSy { get; set; }

        [DataMember]
        public double PaidSys { get; set; }

        [DataMember]
        public DateTime UpdateDate { get; set; }

        [DataMember]
        public string IsICT { get; set; }

        [DataMember]
        public DateTime CreateDate { get; set; }

        [DataMember]
        public int Series { get; set; }

        [DataMember]
        public DateTime TaxDate { get; set; }

        [DataMember]
        public int FinncPriod { get; set; }

        [DataMember]
        public int UserSign { get; set; }

        [DataMember]
        public int UserSign2 { get; set; }

        [DataMember]
        public DateTime VatDate { get; set; }

        [DataMember]
        public double PaidSum { get; set; }

        [DataMember]
        public double PaidSumFc { get; set; }

        [DataMember]
        public double PaidSumSc { get; set; }

        [DataMember]
        public string CurSource { get; set; }

        [DataMember]
        public double Cashremainder { get; set; }

        [DataMember]
        public string IsRIV { get; set; }

        [DataMember]
        public string TypeDisc { get; set; }

        [DataMember]
        public string Confirmed { get; set; }

        [DataMember]
        public string PoPrss { get; set; }

        [DataMember]
        public string ShipToCode { get; set; }

        [DataMember]
        public string PayToCode { get; set; }

         [DataMember]
        public double TotalBefore { get; set; }
    }
}
