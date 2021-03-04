(function () {
    var setting = { "height": 407, "width": 803, "zoom": 17, "queryString": "129 Onewa Road, Northcote, Auckland, New Zealand", "place_id": "ChIJ930NWFk4DW0RV8y2PI195cU", "satellite": false, "centerCoord": [-36.810318061884445, 174.73613849999998], "cid": "0xc5e57d8d3cb6cc57", "lang": "en", "cityUrl": "/nz/auckland", "cityAnchorText": "Map of Auckland, North Island, New Zealand", "id": "map-9cd199b9cc5410cd3b1ad21cab2e54d3", "embed_id": "326159" };
    var d = document;
    var s = d.createElement('script');
    s.src = 'https://1map.com/js/script-for-user.js?embed_id=326159';
    s.async = true;
    s.onload = function (e) {
        window.OneMap.initMap(setting)
    };
    var to = d.getElementsByTagName('script')[0];
    to.parentNode.insertBefore(s, to);
})();