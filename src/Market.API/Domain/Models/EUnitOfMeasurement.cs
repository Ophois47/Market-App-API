using System.ComponentModel;

namespace Market.API.Domain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        Unity = 1,

        [Description("G")]
        Gram = 2,

        [Description("LB")]
        Pound = 3,

        [Description("PT")]
        Pint = 5
    }
}