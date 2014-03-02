# AgeBase: Bitly Url Shortener

The Bitly Url Shortener datatype allows editors to generate a shortened url for the current page being edited. This can be found from Bitly's settings page when logged in. The datatype also accommodates for if you have any custom domains setup for your Bitly account. The datatype requires a login and api key. These are accessible as prevalues on any datatypes which use the shortener.

## Contributing

To raise a new bug, create an [issue](https://github.com/agebase/umbraco-bitly-url-shortener/issues) on the Github repository. To fix a bug or add new features, fork the repository and send a [pull request](https://github.com/agebase/umbraco-bitly-url-shortener/pulls) with your changes. Feel free to add ideas to the repository's [issues](https://github.com/agebase/umbraco-bitly-url-shortener/issues) list if you would to discuss anything related to the package.

## Developing

Amend files within the following folder to make adjustments or enhancements to the package:

    Source

## Publishing

Remember to include all necessary files within the package.xml file. Run the following script, entering the new version number when prompted to created a published version of the package:

    Build\Release.bat

The release script will amend all assembly versions for the package, build the solution and create the package file. The script will also commit and tag the repository accordingly to reflect the new version.
