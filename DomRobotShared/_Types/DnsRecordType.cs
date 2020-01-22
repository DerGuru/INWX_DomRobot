namespace DomRobot
{
    public enum DnsRecordType
    {
        A, //IP v4 Address
        AAAA, //IP v6 Address
        AFSDB,
        CAA, //Certification Authority Authorization
        CERT, //Certificate / CRL
        CNAME, //ALIAS
        HINFO, //Host information
        KEY,
        LOC, //Location information
        MX, //Mail Exchange
        NAPTR, //Naming Authority Pointer
        NS, //Name Server
        PTR, //Pointer e.g. for Reverse records
        RP, //Responsible Person
        SOA, //Start of Authority
        SRV, //Location of Service
        SSHFP,
        TLSA, //Transport Layer Security Authentication
        TXT, //Some Text
        URL
    }
}