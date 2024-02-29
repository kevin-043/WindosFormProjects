using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Calculator
    {
		private decimal currentValue;
		private decimal operand1;
		private decimal operand2;
		private char op;

        public Calculator()
        {
        }

        public Calculator(decimal operand1, decimal operand2, char op)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.op = op;
        }

        public Calculator(decimal currentValue, decimal operand1, decimal operand2, char op)
        {
            this.currentValue = currentValue;
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.op = op;
        }

		public decimal SwitchCase()
		{
            switch (op)
            {
                case '+':
                    return  Add();
                    break;
                case '-':
                    return Subtract(); ;
                    break;
                case '*':
                    return Multiply(); 
                    break;
                case '/':
                    return Divide();
                    break;
                default:
                    return 0;
                    break;
            }
        }

		public decimal Add()
		{
            return operand1 + operand2;
		}

		public decimal Subtract()
		{
            return operand1 - operand2;
        }

        public decimal Multiply()
        {
            return operand1 * operand2;
        }

        public decimal Divide()
        {
            return operand1 / operand2;
        }

        public void Equals()
        {

        }

        public void Clear()
        {

        }

        public char GetSetOp
		{
			get { return op; }
			set { op = value; }
		}


		public decimal GetSetOperand2
		{
			get { return operand2; }
			set { operand2 = value; }
		}


		public decimal GetSetOperand1
		{
			get { return operand1; }
			set { operand1 = value; }
		}

		public decimal GetSetCurrentValue
		{
			get { return currentValue; }
			set { currentValue = value; }
		}

	}
}
