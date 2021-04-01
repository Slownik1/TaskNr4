using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNr4
{
    public struct Zespolone
    {

        public int real;
        public int imaginary;

        Zespolone(int real, int imaginary)
        {

            this.real = real;
            this.imaginary = imaginary;

        }

        public override string ToString()
        {
            return $"{real}+{imaginary}i";
        }

        public override bool Equals(Zespolone other)
        {
            if (other == null)
                return false;

            Zespolone x = (Zespolone)other;

            return other.imaginary == imaginary && other.real == real;
        }

    }
}
