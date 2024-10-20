grammar CSV; // Define a grammar called CSV

file : hdr row+ ; // file is a header followed by one or more rows
hdr  : row ; // header is just a row
row  : field (',' field)* '\r'? '\n' ; // row is a field followed by 0 or more field separated by commas

field
    : TEXT
    | STRING
    |
    ; // field is either TEXT, STRING or empty
    
TEXT   : ~[,\r\n"]+ ; // TEXT is any character other than ',', '\r' or '\n'
STRING : '"' ('""'|~'"')* '"' ; // STRING is a double-quoted string with double-quotes escaped by doubling them