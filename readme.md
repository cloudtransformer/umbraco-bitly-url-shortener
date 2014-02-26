# AgeBase: Bit.ly Url Shortener

The Bit.ly Url Shortener data type allows editors to generate a shortened url for the current page being edited. This can be found from Bit.ly's settings page when logged in. The data type also accommodates for if you have any custom domains setup for your Bit.ly account. The data type requires a login and api key. These are accessible as prevalues on any data types which use the shortener.

## Contributing

To raise a new bug, create an [issue](https://github.com/agebase/umbraco-bitly-url-shortener/issue) on the Github repository. To fix a bug or add new features, fork the repository and send a [pull request](https://github.com/agebase/umbraco-bitly-url-shortener/pulls) with your changes. Feel free to add ideas to the repository's [issues](https://github.com/agebase/umbraco-bitly-url-shortener/issue) list if you would to discuss anything related to the package.

## Developing

Amend files within the following folder to make adjustments or enhancements to the package:

    Source

## Publishing

Remember to include all necessary files within the package.xml file. Run the following script, entering the new version number when prompted to created a published version of the package:

    Build\Release.bat

The release script will amend all assembly versions for the package, build the solution and create the package file. The script will also commit and tag the repository accordingly to reflect the new version.