namespace LR9;

internal abstract class AccommodationBuilder
{
    protected string name = string.Empty;
    protected AccommodationType type;
    protected IPayment? payment;
    protected bool withTransfer;
    protected bool withMiniBar;
    protected bool withPool;
    protected bool withInternet;

    public AccommodationBuilder SetName(string name)
    { this.name = name; return this; }
    public AccommodationBuilder SetType(AccommodationType type)
    { this.type = type; return this; }
    public AccommodationBuilder SetPayment(IPayment payment)
    { this.payment = payment; return this; }
    public AccommodationBuilder WithTransfer()
    { withTransfer = true; return this; }
    public AccommodationBuilder WithMiniBar()
    { withMiniBar = true; return this; }
    public AccommodationBuilder WithPool()
    { withPool = true; return this; }
    public AccommodationBuilder WithInternet()
    { withInternet = true; return this; }

    public abstract AccommodationBase Build();
}