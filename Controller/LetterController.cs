using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Controller
{
    public class LetterController
    {
        private LettersView lettersView;
        private LettersAddView lettersAddView;

        private LetterModel letterModel;
        private Boolean isDone = false; //for processing CRUD operations

        public LetterController(LettersView lettersView)
        {
            this.lettersView = lettersView;
            letterModel = new LetterModel();
        }

        public LetterController(LettersAddView lettersAddView)
        {
            this.lettersAddView = lettersAddView;
            letterModel = new LetterModel();
        }

        public string GenerateNewLetterID()
        {
            try
            {
                return letterModel.GenerateLetterId();

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }
    }
}
