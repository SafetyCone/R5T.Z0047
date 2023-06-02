using System;

using R5T.T0131;
using R5T.T0185;
using R5T.T0185.Extensions;


namespace R5T.Z0047
{
    [ValuesMarker]
    public partial interface IWords : IValuesMarker
    {
        /// <summary>
        /// "Construction"
        /// </summary>
        public IWord Construction => "Construction".ToWord();

        /// <summary>
        /// "No"
        /// </summary>
        public IWord No => "No".ToWord();

        /// <summary>
        /// "Null"
        /// </summary>
        public IWord Null => "Null".ToWord();

        /// <summary>
        /// "Private"
        /// </summary>
        public IWord Private => "Private".ToWord();

        /// <summary>
        /// "Unspecified"
        /// </summary>
        public IWord Unspecified => "Unspecified".ToWord();

        /// <summary>
        /// "Yes"
        /// </summary>
        public IWord Yes => "Yes".ToWord();
    }
}
