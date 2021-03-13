# pervasive-excel-csharp
This repository is a basic tool for linking excel spreadsheets with pervasive databases. 

# Prerequisites
 [Create ODBC Data Source](http://www.multibyte.net/help-desk/knowledge-base/item/27-setup-odbc-connection-to-sage-peachtree-quantum-2010)

# Known Issues
Database does not connect due to 32 bit driver used on 64 bit application.  I cannot find a 64 bit Pervasive Driver. It looks like [Actian](https://communities.actian.com/s/question/0D53300003r9cHf/when-trying-to-connect-to-odbc-data-source-from-64-bit-excel-get-following-error-message) may have one, but i struggled with the installer of the "trial" (it lookslike maybe it requires payment for the full version?) 

# Next approach
I will try running this application in a 32 bit docker container.