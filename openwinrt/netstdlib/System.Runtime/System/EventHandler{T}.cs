﻿using System.Runtime.CompilerServices;

namespace System
{


    public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e); //	where TEventArgs : EventArgs
}

