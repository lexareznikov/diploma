namespace Demography.Infrastructure
{
    public class DatabaseValueAttribute : System.Attribute
    {
        private int _value;

        public DatabaseValueAttribute(int value)
        {
            _value = value;
        }

        public int Value
        {
            get { return _value; }
        }
    }
}