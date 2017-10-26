using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Interfaces;

namespace Project1.Classes
{
    public class BaggageCarSequence : RollingStockItem, ICollection<BaggageCar>, IFreightItem
    {

        private ICollection<BaggageCar> _baggagecars = new List<BaggageCar>();

        public BaggageCarSequence(int weightNativet, string name) 
            : base(weightNativet, name)
        {
        }

        public int Count
        {
            get
            {
                return _baggagecars.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return _baggagecars.IsReadOnly;
            }
        }

        public double FreightCapacity
        {
            get
            {
                return _baggagecars.Sum(x => x.FreightCapacity);
            }
        }

        public double FreightWeight
        {
            get
            {
                return _baggagecars.Sum(x => x.FreightWeight);
            }
        }

        public void Add(BaggageCar item)
        {
            _baggagecars.Add(item);
        }

        public void Clear()
        {
            _baggagecars.Clear();
        }

        public bool Contains(BaggageCar item)
        {
            return _baggagecars.Contains(item);
        }

        public void CopyTo(BaggageCar[] array, int arrayIndex)
        {
            _baggagecars.CopyTo(array, arrayIndex);
        }

        public bool Remove(BaggageCar item)
        {
            return _baggagecars.Remove(item); ;
        }

        public IEnumerator<BaggageCar> GetEnumerator()
        {
            return _baggagecars.GetEnumerator(); ;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override double Weight()
        {
            return _baggagecars.Sum(x => x.Weight()+x.FreightWeight); ;
        }

        public override string Name()
        {
            return _name;
        }
    }
}
