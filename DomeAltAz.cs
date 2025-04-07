/*
 * This program and code is OPEN SOURCE and you can modifi it as long as you use a branch and keep it updated.
 * The master branch is my coding but will accept updates to the master on approval.
*/

using MathNet.Numerics.LinearAlgebra.Double;

namespace iOptron_Mount_Control
{
    public class DomeAltAz
    {
        internal DenseVector cogtoO;

        public double DomeAzimuth { get; internal set; }
        public double DomeAltitude { get; internal set; }
    }
}