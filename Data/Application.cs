using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class Application
    {
        private int id;
        private int loan_id;
        private int applicant_id;
        private int score;
        private int credit_score_company_id;
        private int underwritter_decision;
        private double amount;

        public Application() { }

        public Application( int id, 
                            int loan_id, 
                            int applicant_id, 
                            int score, 
                            int credit_score_company_id,
                            int underwritter_decision,
                            double amount)
        {
            this.id = id;
            this.loan_id = loan_id;
            this.applicant_id = applicant_id;
            this.score = score;
            this.credit_score_company_id = credit_score_company_id;
            this.underwritter_decision = underwritter_decision;
            this.amount = amount;
        }

        ~Application() { }

        public void setId(int val) { id = val; }
        public void setLoanId(int val) { loan_id = val; }
        public void setApplicantId(int val) { applicant_id = val; }
        public void setScore(int val) { score = val; }
        public void setCreditScoreCompanyId( int val) { credit_score_company_id = val; }
        public void setUnderwritterDecision( int val) { underwritter_decision = val; }
        public void setAmount(double val) { amount = val; }

        public int getId() { return id; }
        public int getLoanId() { return loan_id; }
        public int getApplicantId() { return applicant_id; }
        public int getScore() { return score; }
        public int getCreditScoreCompanyId() { return credit_score_company_id; }
        public int getUnderwritterDecision() { return underwritter_decision; }
        public double getAmount() { return amount; }
    }
}
