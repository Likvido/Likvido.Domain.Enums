namespace Likvido.Domain.Enums
{
    /// <summary>
    /// Identifies a payout line's subtype. Use <c>PayoutLineSubType?</c> when the subtype can be absent;
    /// <see langword="null"/> is distinct from <see cref="PayoutLineSubType.Principal"/>.
    /// </summary>
    public enum PayoutLineSubType
    {
        Principal = 0,
        SuccessFee = 1,
        CollectionFees = 2,
        InterestFees = 3,
    }
}
