using System.ComponentModel;

namespace Likvido.Domain.Enums
{
    public enum AccountSystemType
    {
        [Description("e-conomic")]
        Economic = 0,

        [Description("Billy's")]
        Billy = 1,

        [Description("Dinero")]
        Dinero = 2,

        [Description("Dynamics 365 Business Central")]
        BusinessCentral = 3,
    }
}
