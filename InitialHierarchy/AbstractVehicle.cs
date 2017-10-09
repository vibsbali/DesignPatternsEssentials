namespace InitialHierarchy
{
    public abstract class AbstractEngine : IEngine
    {
        public virtual int Size { private set; get; }
        public virtual bool Turbo { private set; get; }
        protected AbstractEngine(int size, bool isTurbo)
        {
            Size = size;
            Turbo = isTurbo;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ({Size})";
        }
    }

    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) 
            : base(size, false)
        {
        }
    }

    public class TurboEngine : AbstractEngine
    {
        public TurboEngine(int size) : base(size, true)
        {
        }
    }


}
