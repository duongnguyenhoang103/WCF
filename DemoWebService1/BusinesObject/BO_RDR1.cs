using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BusinesObject
{
    [DataContract]
   public  class BO_RDR1
    {
        [DataMember ]
        public int DocEntry { get; set; }

        [DataMember]
        public int LineNum { get; set; }

        [DataMember]
        public int TargetType { get; set; }

        [DataMember]
        public int TrgetEntry { get; set; }

        [DataMember]
        public string BaseRef { get; set; }

        [DataMember]
        public int BaseType { get; set; }

        [DataMember]
        public int BaseEntry { get; set; }

        [DataMember]
        public int BaseLine { get; set; }

        [DataMember]
        public string LineStatus { get; set; }

        [DataMember]
        public string ItemCode { get; set; }

        [DataMember]
        public string Dscription { get; set; }

        [DataMember]
        public double Quantity { get; set; }

        [DataMember]
        public double OpenQty { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public double Rate { get; set; }

        [DataMember]
        public double DiscPrcnt { get; set; }

        [DataMember]
        public double LineTotal { get; set; }

        [DataMember]
        public double TotalFrgn { get; set; }

        [DataMember]
        public double OpenSum { get; set; }

        [DataMember]
        public double OpenSumFC { get; set; }

        [DataMember]
        public string WhsCode { get; set; }

        [DataMember]
        public int SlpCode { get; set; }
        public string AcctCode { get; set; }

        [DataMember]
        public double PriceBefDi { get; set; }

        [DataMember]
        public DateTime DocDate { get; set; }

        [DataMember]
        public string OcrCode { get; set; }

        [DataMember]
        public string Project { get; set; }

        [DataMember]
        public string CodeBars { get; set; }

        [DataMember]
        public double VatPrcnt { get; set; }

        [DataMember]
        public string VatGroup { get; set; }

        [DataMember]
        public double PriceAfVAT { get; set; }

        [DataMember]
        public int BaseDocNum { get; set; }

        [DataMember]
        public double VatSum { get; set; }

        [DataMember]
        public double VatSumFrgn { get; set; }

        [DataMember]
        public double VatSumSy { get; set; }

        [DataMember]
        public int FinncPriod { get; set; }

        [DataMember]
        public string ObjType { get; set; }

        [DataMember]
        public double GrssProfit { get; set; }

        [DataMember]
        public double GrssProfFC { get; set; }

        [DataMember]
        public string TaxCode { get; set; }

        [DataMember]
        public double BaseQty { get; set; }

        [DataMember]
        public double BaseOpnQty { get; set; }

        [DataMember]
        public double VatDscntPr { get; set; }

        [DataMember]
        public double GTotal { get; set; }

        [DataMember]
        public double GTotalFC { get; set; }

        [DataMember]
        public string OcrCode2 { get; set; }

        [DataMember]
        public string OcrCode3 { get; set; }

        [DataMember]
        public string OcrCode4 { get; set; }

        [DataMember]
        public string OcrCode5 { get; set; }

        [DataMember]
        public double Factor1 { get; set; }

        [DataMember]
        public double Factor2 { get; set; }

        [DataMember]
        public double Factor3 { get; set; }

        [DataMember]
        public double Factor4 { get; set; }

        [DataMember]
        public string UseBaseUn { get; set; }

        [DataMember]
        public string unitMsr { get; set; }

        [DataMember]
        public double NumPerMsr { get; set; }

        [DataMember]
        public DateTime ShipDate { get; set; }

        [DataMember]
        public string FreeTxt { get; set; }

    }
}
