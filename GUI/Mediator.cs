using System;

public static class Mediator
{
    private static string nameEmployee;
    private static string memberID;
    private static string goiTap;
    private static decimal thanhTien;
    private static int soHD;
    private static DateTime date;
    private static int grnID;
    private static int supplierID;
    private static DateTime endDate;

    public static string NameEmployee
    {
        get { return nameEmployee; }
        set { nameEmployee = value; }

    }
         public static string MemberID
    {
        get { return memberID; }
        set { memberID = value; }
    }
    public static string GoiTap
    {
        get { return goiTap; }
        set { goiTap = value; }
    }
    public static decimal ThanhTien
    { 
        get { return thanhTien; }
        set { thanhTien = value; }
    }
    public static int SoHD
    {
        get { return soHD; }
        set { soHD = value; }
    }
    public static DateTime Date
    {
        get { return date; }
        set { date = value; }
    }
    public static int GrnID
    {
        get { return grnID; }
        set { grnID = value; }
    }
    public static int SupplierID
    {
        get { return supplierID; }
        set { supplierID = value; }
    }
    public static DateTime ed
    {
        get { return endDate; }
        set { endDate = value; }
    }
}