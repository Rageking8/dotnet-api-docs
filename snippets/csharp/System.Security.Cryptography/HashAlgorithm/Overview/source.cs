﻿using System;
using System.Windows.Forms;
using System.Security.Policy;
using System.Security.Cryptography;

public class Form1: Form
{
 protected Byte[] dataArray;

 protected void Method()
 {
// <Snippet1>
 HashAlgorithm sha = SHA256.Create();
 byte[] result = sha.ComputeHash(dataArray);
// </Snippet1>
 }
}
