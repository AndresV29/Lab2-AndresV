namespace DTO
{
    

    
    public class Loan : BaseClass
    {
        public Loan() {
            Id = 1;
            type = 0;
            name = "personal";
            currency = 0;
            loanConditions.comission = 1.1;
            loanConditions.yearlyInterest = 0;
            loanConditions.addYearlyInterest = 0;
        }
        // 0 - 2 hipoteca, personal,vehicular
        public int type { get; set; }
        public string name { get; set; }
        public int currency { get; set; }

        public Conditions loanConditions { get; set; }
    }
    
}