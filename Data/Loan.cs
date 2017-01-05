using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Loan
    {
        private int borrowing_rate;
        private int id;
        private string name;
        private string provider;
        private int years;

        //public ClassView.Package1.LoanHandler m_LoanHandler;

        public Loan(){}
        ~Loan(){}

        public int getBorrowingRate(){ return borrowing_rate; }
        public int getId(){ return id; }
        public string getName(){ return name; }
        public string getProvider(){ return provider; }
        public int getYears() { return years; }

        public void setBorrowingRate( int val ) {}
        public void setId( int val ) { id = val; }
        public void setName( string val ) { name = val; }
        public void setProvider( string val ) { provider = val; }
        public void setYears( int val ) { years=val; }
    }
}