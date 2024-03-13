﻿using Xeptions;

namespace NetCoreKit.Exceptions;

public class ConflictException : Xeption
{
	public ConflictException(string message) : base(message)
	{
	}

	public ConflictException(string message, Exception innerException) : base(message, innerException)
	{
	}
}