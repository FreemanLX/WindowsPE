namespace WindowsPE.Algorithms
{
    public class Pair<T, U>
    {
        public T first;
        public U second;

        public Pair(){}

        public Pair(T first, U second)
        {
            this.first = first;
            this.second = second;
        }
        
	    public static Pair<T, U> makePair(T first, U second){
	        return new Pair<T, U>(first, second);
	    }
    }
}
