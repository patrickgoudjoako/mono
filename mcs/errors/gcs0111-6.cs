// CS0111: A member `C.Foo()' is already defined. Rename this member or use different parameter types
// Line: 12
// Compiler options: -langversion:linq

public partial class C
{
	partial void Foo ();
}

public partial class C
{
	void Foo ()
	{
	}
}
