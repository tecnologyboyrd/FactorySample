using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    //Creator
    public abstract class FactoryMathOpr
    {
        public abstract IMathOpr OprExec();
    }

    //Concret Creator
    public class AdditionOprFactory : FactoryMathOpr
    {
        private decimal _valor1;
        private decimal _valor2;

        public AdditionOprFactory(decimal valor1, decimal valor2)
        {
            _valor1 = valor1;
            _valor2 = valor2;            
        }

        public override IMathOpr OprExec()
        {
            return new AdditionOpr(_valor1, _valor2);
        }
    }

    //Concret Creator
    public class SubstractOprFactory : FactoryMathOpr
    {
        private decimal _valor1;
        private decimal _valor2;

        public SubstractOprFactory(decimal valor1, decimal valor2)
        {
            _valor1 = valor1;
            _valor2 = valor2;
        }

        public override IMathOpr OprExec()
        {
            return new SubstractOpr(_valor1, _valor2);
        }
    }


    //Concret Product
    public class AdditionOpr : IMathOpr
    {
        private decimal _valor1;
        private decimal _valor2;

        public AdditionOpr(decimal valor1, decimal valor2)
        {
            _valor1 = valor1;
            _valor2 = valor2;
        }

        public decimal OprExec(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }
    }

    //Concret Product
    public class SubstractOpr : IMathOpr
    {
        private decimal _valor1;
        private decimal _valor2;

        public SubstractOpr(decimal valor1, decimal valor2)
        {
            _valor1 = valor1;
            _valor2 = valor2;
        }

        public decimal OprExec(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }
    }

    //Product
    public interface IMathOpr
    {
        public decimal OprExec(decimal valor1, decimal valor2);
    }

   
}
