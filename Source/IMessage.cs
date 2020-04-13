namespace ZenMessageBus.Source
{
    public interface IMessage
    {
        public object Sender { get; }
    }
}