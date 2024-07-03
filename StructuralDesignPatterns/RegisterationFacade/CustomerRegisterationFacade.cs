using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.RegisterationFacade
{
    public class CustomerRegisterationFacade
    {
        Validator validator = new Validator();
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        EmailConfirmation emailConfirmation = new EmailConfirmation();

        public void register()
        {
            dataAccessLayer.accessData();
            validator.validate();
            emailConfirmation.sendEmail();
        }
    }
}
