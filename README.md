FastDBF
=======

A free and open source .net library for reading/writing DBF files. Fast and easy to use. Supports writing to forward-only streams which makes it easy to write dbf files in a web server environment.

This is a fork of [Social Explorer FastDBF](https://github.com/SocialExplorer/FastDBF) 
with .NET Core and .Net Standard support

Enjoy

ssunbob

## Improvements
* Merge some pull-requests from original branch (#9,#17)
* Improve the situation when field name contains multibyte characters like CJK. 
* MultiTaget Mapping to NET40,NET45 and NET461 for example (**Need VS2019**).
You can adjust this based on your workload.
* Use preprocessor symbols to improve the testApp running in DotnetCore Environment.