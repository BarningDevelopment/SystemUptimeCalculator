﻿using System.Collections.Generic;


namespace System.Management
{
    internal class ManagementObjectSearcher
    {
        private string v;

        public ManagementObjectSearcher(string v)
        {
            this.v = v;
        }

        internal IEnumerable<ManagementObject> Get()
        {
            throw new NotImplementedException();
        }
    }
}