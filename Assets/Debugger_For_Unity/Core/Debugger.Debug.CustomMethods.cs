#region Author
/// <summary>--------------------------------------------------
//		Author:			He, Mingfei
//		Namespace:		<Debugger_For_Unity.something>
//		Class:			Debugger.Debug.CustomMethods
//		Date:			7/20/2018 10:10:08 AM
/// </summary>--------------------------------------------------
#endregion

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Debugger_For_Unity {

	/// <summary>
	/// Class Explanation
	/// </summary>
	public partial class Debugger
	{
        #region  Attributes and Properties
        /// <summary>
        /// Public Members
        /// </summary>

        /// <summary>
        /// Properties
        /// </summary>

        /// <summary>
        /// Protected Members
        /// </summary>

        /// <summary>
        /// Private Members
        /// </summary>

        #endregion


        #region Engine Methods

        #endregion


        #region Public Methods
        [DebuggerButtonDebug("tt1", 1)]
        public void Test1()
        {

        }


        [DebuggerButtonDebug("tt2", 1)]
        [DebuggerSelectDebug("tt2", 1)]
        [DebuggerCodeDebug("apple", "tt2Code")]
        public void Test2()
        {

        }

        [DebuggerButtonDebug("tt3", 1)]
        public void Test3()
        {

        }

        [DebuggerCodeDebug("apple666", "tt4Codeddd")]
        public void Test4()
        {

        }

        [DebuggerSelectDebug("tt555555", 1)]
        [DebuggerCodeDebug("addddpple", "tt5Cdddode")]
        public void Test5()
        {

        }
        #endregion


        #region Protected Methods

        #endregion


        #region Private Methods

        #endregion


        #region Static Methods

        #endregion
    }
}