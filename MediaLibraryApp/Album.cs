using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp 
{
    class Album : MediaType
    {
       
       public string Band;
       public string Loanee;
       public bool OnLoan;
       


        public Album(string title, string band) : base(title)
        {
            Band = band;
        }

        public void Loan()
        {
            OnLoan = true;
        }

        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }

        public string GetDisplayText()
        {
            string text = "Album: " + Title + " by " + Band;

            if (OnLoan)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                    text = text + " (Currently on loan to " + Loanee + ")";
                }
                else
                {
                    text += " (Currently on loan)";
                }
            }

            return text;
        }

       
    }

}
