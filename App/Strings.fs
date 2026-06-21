module Strings

// 17.1
let rec pow = function
    | ("", _) -> ""
    | (str, count) when count <= 0 -> ""
    | (str, 1) -> str
    | (str, count) -> str + pow(str, count - 1)

// 17.2
let isIthChar  = function
    | (_, index, _) when index < 0 -> false
    | (str, index, char) when (String.length str) - 1 < index -> false
    | (str, index, char) -> str[index] = char

// 17.3
let rec occFromIth = function     
     | (_, index, _) when index < 0 -> 0
     | (str, index, _) when String.length str - 1 < index -> 0
     | (str, index, char) when str[index] = char -> 1 + occFromIth(str,index + 1,char)
     | (str, index, char) -> occFromIth(str,index + 1,char)