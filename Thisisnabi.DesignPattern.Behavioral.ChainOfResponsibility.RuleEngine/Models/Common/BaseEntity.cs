using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Models.Common
{
    public class BaseEntity
    {
        #region Properties
        public Guid Id { get; set; }
        public DateTime InsertDate { get; private set; } = DateTime.Now;
        public bool IsDeleted { get; private set; } = false;
        public DateTime? DeleteDate { get; private set; }
        #endregion
        #region Methods
        public void SetDeleteAction()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now;
        }
             
        #endregion
    }
}
