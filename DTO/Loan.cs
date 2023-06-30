namespace DTO
{
    public class Loan : BaseClass
    {
        // 0 - 2 hipoteca, personal,vehicular
        public int[] type { get; set; }
        public string name { get; set; }
        public int[] currency { get; set; } 

        public Conditions loanConditions { get; set; }
    }
}