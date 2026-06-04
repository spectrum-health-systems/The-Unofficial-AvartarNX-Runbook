<div align="center">

![](../../.github/resources/images/logos/abatab-documentation-project-logo.png)

</div>

***

# About Abatab.ThirdParty.DocFX

Abatab uses [DocFX](https://dotnet.github.io/docfx/index.html) to generate Abatab API documentation.

The DocFX instance for Abatab is located in `src/ThirdParty/DocFX/`.

# Building API documentation

The API documentation is rebuilt when you build/rebuild Abatab.

During development, the API documentation is rebuilt *a lot*. Building the API documentation results in longer build times, but this way the API documentation is always up-to-date and making it available to the public is fairly straight forward.

When you build Abatab, DocFX rebuilds the API documentation to `src/ThirdParty/DocFX/_site`. 

> **Testing API documentation during development**  
> During development, use `src/ThirdParty/DocFX/_site` to test the API documentation.

For the majority of a development cycle, DocFX generated data can be ignored. And since the GitHub Pages that host the API documentation is based on the main branch, and not available to the public, you don't need to worry about the documentation being correct (although keeping on top of the XML comments will make your life easier when you are ready to make the documentation available to the public).

At the *end* of a development cycle, there are a few things you need to do to ensure that the current API documentation is available to the public.

# Making the API documentation public

The current GitHub Pages that host the API documentation is based on the main branch, so API documentation during development is not available to the public.

To make the API documentation available to the public:

1. Verify that the contents of `src/ThirdParty/DocFX/_site` is correct/up-to-date.
2. Move the content in `src/ThirdParty/DocFX/_site` to `docs/`
3. Merge the development branch with the main branch

## Publishing to GitHub Pages

The API documentation will automatically be published to GitHub Pages...but it may take a few minutes, so be patient!

# Important DocFX files

The following files are important to the navigation of the GitHub Pages:

- **src/Abatab.ThirdParty/DocFx/index.html**  
The content for the GitHub Pages [landing page](https://spectrum-health-systems.github.io/Abatab/)
- **src/Abatab.ThirdParty/DocFx/toc.yml**  
The header for the GitHub Pages [landing page](https://spectrum-health-systems.github.io/Abatab/)

<br>
<br>

***

<div align="center">
	<h6>
			This document is part of the <a href="https://spectrum-health-systems.github.io/Abatab-Documentation-Project/">Abatab Documentation Project</a>
			<br>
			<sub style="color:DarkSlateGrey;">
					Last updated: <b>November 6, 2023</b> [b231106.1057]
			</sub>
		</h6>
</div>
