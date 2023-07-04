using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogic
{
    public class LoanManager
    {
        public List<Loan> GetAllLoans()
        {
            //Todo: Aqui debería ir a la BD, traer los articulos y retornar las instancias

            List<Loan> lstLoan = new List<Loan>();
            //Crear Articulo
            var newLoan = new Loan();
            //newArticle.Title = "Titulo asignado desde el Manager";

            //Agregarlo a la lista
            lstLoan.Add(newLoan);

            return lstLoan;
        }

    }
}
