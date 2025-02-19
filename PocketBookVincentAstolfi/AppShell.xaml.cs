﻿namespace PocketBookVincentAstolfi;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("AllBooksPage", typeof(AllBooksPage));
        Routing.RegisterRoute("AllAuthorsPage", typeof(AllAuthorsPage));
		Routing.RegisterRoute("SpecificBookDescriptionPage", typeof(SpecificBookDescriptionPage));
    }
}
