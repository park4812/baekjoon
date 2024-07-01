import Foundation

func solution(_ my_string:String, _ overwrite_string:String, _ s:Int) -> String {
    
    var modifiedString = my_string
    let startIndex = my_string.index(my_string.startIndex, offsetBy: s)
    let endIndex = my_string.index(startIndex, offsetBy: overwrite_string.count, limitedBy: my_string.endIndex) ?? my_string.endIndex
    modifiedString.replaceSubrange(startIndex..<endIndex, with: overwrite_string)
    return modifiedString
    
}