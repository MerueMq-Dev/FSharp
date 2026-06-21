module Strings

// 17.1
let rec pow = function
    | ("", _) -> ""
    | (str, times) when times <= 0 -> ""
    | (str, 1) -> str
    | (str, times) -> str + pow(str, times - 1)

// 17.2
let sisIthChar  = function
    | (_, index, _) when index < 0 -> false
    | (str, index, _) when (String.length str) - 1 < index -> false
    | (str, index, symbol) -> str.[index] = symbol

// 17.3
let rec occFromIth = function     
     | (_, index, _) when index < 0 -> 0
     | (str, index, _) when String.length str - 1 < index -> 0
     | (str, index, symbol) when str.[index] = symbol -> 1 + occFromIth(str,index + 1,symbol)
     | (str, index, symbol) -> occFromIth(str,index + 1,symbol)