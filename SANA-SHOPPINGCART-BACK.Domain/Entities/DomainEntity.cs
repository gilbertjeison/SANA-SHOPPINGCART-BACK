using System.ComponentModel.DataAnnotations.Schema;

namespace SANA_SHOPPINGCART_BACK.Domain.Entities;

public class DomainEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
}
