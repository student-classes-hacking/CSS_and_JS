
////////////////////////////
////////// IMPORTS /////////
///////////////////////////


///////////////////////////
////////// MAIN ///////////
///////////////////////////



let initMap = () =>
{
    var map = L.map('map').setView([41.36991649599404, 2.116769141020502], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '� OpenStreetMap contributors'
    }).addTo(map);

    //var homeIcon = L.divIcon({
    //    className: 'custom-div-icon',
    //    html: "<div style='background-color: #fff; border: 1px solid #666; text-align: center; line-height: 38px; width: 38px; height: 38px; border-radius: 50%;'><i style='font-size: 24px; color: #f00;'>&#127968;</i></div>", 
    //    iconSize: [38, 38],
    //    iconAnchor: [19, 38],
    //    popupAnchor: [0, -38]
    //});

    var cafeIcon = L.divIcon({
        className: 'custom-div-icon',
        html: "<div style='background-color: #fff; border: 1px solid #666; text-align: center; line-height: 38px; width: 38px; height: 38px; border-radius: 50%;'><i style='font-size: 24px; color: #6b4f4f;'>&#9749;</i></div>", // Emoji de taza de caf�
        iconSize: [38, 38],
        iconAnchor: [19, 38],
        popupAnchor: [0, -38]
    });


    //var markerMetro = L.marker([41.368752652976376, 2.116526479269999], { icon: homeIcon }).addTo(map)
    //    .bindPopup('Metro Torrassa')
    //    .openPopup();

    var markerLocation = L.marker([41.36991649599404, 2.116769141020502], { icon: cafeIcon }).addTo(map)
        .bindPopup('Calle Vallparda, 122, Hospitalet de Llobregat')
        .openPopup();
}
//let test = () => alert("alerta test");


//let addClass = (elementReference, nameClass) => elementReference.classList.add(nameClass);
//let removeClass = (elementReference, nameClass) => elementReference.classList.remove(nameClass);
//let getWindowDimensions = () => {
//    return {
//        width: window.innerWidth,
//        height: window.innerHeight
//    }
//}
//let getRect = (elementReference) => {
//    var rect = elementReference.getBoundingClientRect();
//    return {
//        left: rect.left,
//        top: rect.top
//    }
//}


////////////////////////////
////////// EXPORTS /////////
///////////////////////////

export let module =
    {
        initMap,
        //test,
        //addClass,
        //removeClass,
        //getWindowDimensions,
        //scroll_bottom,
        //getRect,

    }