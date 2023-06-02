using System;


namespace R5T.Z0047
{
    public class Words : IWords
    {
        #region Infrastructure

        public static IWords Instance { get; } = new Words();


        private Words()
        {
        }

        #endregion
    }
}
