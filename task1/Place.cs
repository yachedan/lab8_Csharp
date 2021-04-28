namespace task1
{
    public abstract class Place
    {
        protected double _area = 0;
        protected int _pop = 0;
        public double GetDensity() => _area/_pop;
        public abstract void  GetVillage();
        public abstract void GetCity();
        public int GetPop() => _pop;
    }
}