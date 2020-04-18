using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Transactions
{
    public class TransactionType
    {
        public TransactionType()
        {

        }

        // take the full control of id generating.
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionTypeId { get; set; }

        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }

        #region Relations - Navigation Properties

        public virtual List<Exchange> Exchanges { get; set; }

        #endregion
    }
}
