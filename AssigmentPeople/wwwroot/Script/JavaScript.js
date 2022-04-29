const peopleList;
function Search() {
    storePeopleList();
    const searchResult = (document.getElementById("exact").checked) ? searchExact() :searchContent();

    //splitedTbody.forEach(element => console.log(element));
    var choices = (document.getElementById("exact").checked) ? "Exact" : "content";
    choices += (document.getElementById("casesensitve").checked) ? " Casesensitive" : "";
    choices += (document.getElementById("name").checked) ? " name" : " city";
    // if (document.getElementById("exact").checked) {
    choices += " " + document.getElementById("searchfor").value;
    //}
    //else {
    //    newContent += "content";
    //}
    WriteTable(splittedTbody);
//    document.getElementsByTagName("tbody")[0].innerHTML = choices + " " + splittedTbody.length + " posts in \n" + splittedTbody;
    //   const newContent = oldContent.forEach(MakeRows);
    //  document.getElementsByTagName("tbody")[0].innerHTML = oldContent+"\nmy new list\n" + newContent;
}

function SearchModel() {
    WriteTable(model);
}
 
function SortList(model) {

    sortField=(document.getElementById("name").checked) ? "Name" : "City";
    var sorted = model.map(sortField).Sort();

  /*
    casesensitive=document.getElementById("casesensitve").checked) ? " Casesensitive" : "";

    model.Sort(function ())
    var peopleList = document.getElementsByTagName("tbody")[0].innerHTML;
*/
    document.getElementsByTagName("tbody")[0].innerHTML = "My new list\n" + sorted;

}
function SortListReversed(model) {
    var peopleList = document.getElementsByTagName("tbody")[0].innerHTML;
    document.getElementsByTagName("tbody")[0].innerHTML = "My new list\n" + peopleList;
}

function MakeMatris(tbody) {
    var all = SplitTbody(tbody);
    var posts = Array();
    for (index = 0; index < all.length; index += 3) {
        posts[index/3] = { name: all[index], city: all[index + 1], link:all[index+2]}
        console.log(posts[index/3]);
    }
    return posts;
}
function SplitTbody() {
    tbody = document.getElementsByTagName("tbody")[0].innerHTML;
    var people = tbody.split("</td>");
    var posts = Array();
    var fields = Array();
    for (index = 0; index < people.length; index++) {
            people[index] = people[index].substring(people[index].search("<td>") + 4);
    }
    return people;
}

function WriteTable(matris) {
    console.log(matris);
    var htmlString;
    for (index = 0; index < matris.length-1; index++) {
        htmlString += "<tr><td>" + matris[index].name + "</td><td>" + matris[index].city + "</td><td>" + matris[index].link + "</td></tr>\n";
    }
    document.getElementsByTagName("tbody")[0].innerHTML ="Written by me\n"+htmlString;
}

function MakeRows(person) {
    return "<tr>" + person + "</tr>";

}

function SearchExact() {
    var result = Arrays();
    var exactSearch=(document.getElementById("exact").checked) ?true : false;
    var caseSensitive = (document.getElementById("casesensitve").checked) ? true :false;
    var searchByField = (document.getElementById("name").checked) ? " name" : " city";
    peopleList.foreach()
        if (person.Name.Contains(search) || person.PhoneNumber.Contains(search) || person.CityName.Contains(search)) {
            searchResult.Add(person);
        }
    }
    return Result;
}
function SearchExact() {
    var result = Arrays();
    var exactSearch = (document.getElementById("exact").checked) ? true : false;
    var caseSensitive = (document.getElementById("casesensitve").checked) ? true : false;
    var searchByField = (document.getElementById("name").checked) ? " name" : " city";
    matris.foreach.
        foreach( person in peopleList)
    {
        if (person.Name.Contains(search) || person.PhoneNumber.Contains(search) || person.CityName.Contains(search)) {
            searchResult.Add(person);
        }
    }
    return Result;
}

function storePeopleList() {
    if (peopleList === null) {
        const tbody = document.getElementsByTagName("tbody")[0].innerHTML;
        if (peopleList === null) peopleList = MakeMatris(tbody);
    }
    return
}