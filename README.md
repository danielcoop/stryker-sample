<div id="top"></div>

<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<br/>

<!-- ABOUT THE PROJECT -->
## About The Project

A test project to look at Stryker.Net and examples of how code coverage isn't a completely truthful metric.

Stryker.Net (and other Stryker products) facilitate a testing strategy called mutation testing.  This is where deliberate bugs, called mutants, are placed into the code and the tests are run.

If a test then fails, a _mutant_ is killed, and that means the test is doing it's job correctly.
If the tests pass then a _mutant_ has survived.  This means your tests would not able to detect if a bug was introduced, which is a bad thing...

More killed mutants = better tests are at trapping bugs :D

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

The project has a couple of classes to get started.

1. `AgeCheck`
This test highlights that even though code coverage results might _say_ 100% coverage, mutations show that this is not the case.

2. `AgeCheck`
These tests show that Stryker doesn't have to be used to check test code.  In these examples, the differences between the implementations of `IsOpen_` show that mutants are much easier to kill in one than the other.

### Installation

1. install tools
  ```sh
  dotnet tool install
  ```

2. run stryker
  ```sh
  dotnet stryker
  ```

This will produce a HTML Stryker template for you to view and see how many mutants you've killed.

[![Sample Report][sample-report]][sample-report]

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

This sample is entirely possible because of Stryker.Net.  If you want to start using mutation testing in your workflow, check out their docs - [https://stryker-mutator.io/docs](https://stryker-mutator.io/docs)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/danielcoop/stryker-sample.svg?style=for-the-badge
[contributors-url]: https://github.com/danielcoop/stryker-sample/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/danielcoop/stryker-sample.svg?style=for-the-badge
[forks-url]: https://github.com/danielcoop/stryker-sample/network/members
[stars-shield]: https://img.shields.io/github/stars/danielcoop/stryker-sample.svg?style=for-the-badge
[stars-url]: https://github.com/danielcoop/stryker-sample/stargazers
[issues-shield]: https://img.shields.io/github/issues/danielcoop/stryker-sample.svg?style=for-the-badge
[issues-url]: https://github.com/danielcoop/stryker-sample/issues
[license-shield]: https://img.shields.io/github/license/danielcoop/stryker-sample.svg?style=for-the-badge
[license-url]: https://github.com/danielcoop/stryker-sample/blob/main/LICENSE.txt
[sample-report]: images/sample-report.png