using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplomowanie
{
    public interface IThesisUpload
    {
        bool Check();
        void Update(string PromotorNameSurname);
    }
  


}
