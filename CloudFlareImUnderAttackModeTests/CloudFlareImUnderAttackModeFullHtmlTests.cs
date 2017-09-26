﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudFlareImUnderAttackMode;
using NUnit.Framework;

namespace CloudFlareImUnderAttackModeTests
{
    class CloudFlareImUnderAttackModeFullHtmlTests
    {
        const string NEW_REQUEST_TO_IMAGES_NGA_GOV = @"HTTP/1.1 503 Service Temporarily Unavailable
Date: Sat, 16 Sep 2017 05:21:39 GMT
Content-Type: text/html; charset=UTF-8
Transfer-Encoding: chunked
Connection: close
Set-Cookie: __cfduid=ddb5545c784f35ed52d4a026babff08291505539299; expires=Sun, 16-Sep-18 05:21:39 GMT; path=/; domain=.nga.gov; HttpOnly
X-Frame-Options: SAMEORIGIN
Cache-Control: no-cache
Server: cloudflare-nginx
CF-RAY: 39f1622f368e2e6f-MIA

11c0
<!DOCTYPE HTML>
<html lang=""en-US"">
<head>
  <meta charset=""UTF-8"" />
  <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
  <meta http-equiv=""X-UA-Compatible"" content=""IE=Edge,chrome=1"" />
  <meta name=""robots"" content=""noindex, nofollow"" />
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"" />
  <title>Just a moment...</title>
  <style type=""text/css"">
    html, body {width: 100%; height: 100%; margin: 0; padding: 0;}
    body {background-color: #ffffff; font-family: Helvetica, Arial, sans-serif; font-size: 100%;}
    h1 {font-size: 1.5em; color: #404040; text-align: center;}
    p {font-size: 1em; color: #404040; text-align: center; margin: 10px 0 0 0;}
    #spinner {margin: 0 auto 30px auto; display: block;}
    .attribution {margin-top: 20px;}
    @-webkit-keyframes bubbles { 33%: { -webkit-transform: translateY(10px); transform: translateY(10px); } 66% { -webkit-transform: translateY(-10px); transform: translateY(-10px); } 100% { -webkit-transform: translateY(0); transform: translateY(0); } }
    @keyframes bubbles { 33%: { -webkit-transform: translateY(10px); transform: translateY(10px); } 66% { -webkit-transform: translateY(-10px); transform: translateY(-10px); } 100% { -webkit-transform: translateY(0); transform: translateY(0); } }
    .bubbles { background-color: #404040; width:15px; height: 15px; margin:2px; border-radius:100%; -webkit-animation:bubbles 0.6s 0.07s infinite ease-in-out; animation:bubbles 0.6s 0.07s infinite ease-in-out; -webkit-animation-fill-mode:both; animation-fill-mode:both; display:inline-block; }
  </style>

    <script type=""text/javascript"">
  //<![CDATA[
  (function(){
    var a = function() {try{return !!window.addEventListener} catch(e) {return !1} },
    b = function(b, c) {a() ? document.addEventListener(""DOMContentLoaded"", b, c) : document.attachEvent(""onreadystatechange"", b)};
    b(function(){
      var a = document.getElementById('cf-content');a.style.display = 'block';
      setTimeout(function(){
        var s,t,o,p,b,r,e,a,k,i,n,g,f, WvlQzUV={""LBvwmvD"":!+[]+!![]};
        t = document.createElement('div');
        t.innerHTML=""<a href='/'>x</a>"";
        t = t.firstChild.href;r = t.match(/https?:\/\//)[0];
        t = t.substr(r.length); t = t.substr(0,t.length-1);
        a = document.getElementById('jschl-answer');
        f = document.getElementById('challenge-form');
        ;WvlQzUV.LBvwmvD+=+((!+[]+!![]+!![]+!![]+[])+(!+[]+!![]+!![]+!![]+!![]+!![]+!![]));WvlQzUV.LBvwmvD+=+((+!![]+[])+(+[]));WvlQzUV.LBvwmvD+=+((!+[]+!![]+!![]+!![]+[])+(!+[]+!![]+!![]+!![]));WvlQzUV.LBvwmvD-=+((+!![]+[])+(!+[]+!![]+!![]+!![]));WvlQzUV.LBvwmvD+=!+[]+!![]+!![]+!![]+!![]+!![]+!![]+!![]+!![];WvlQzUV.LBvwmvD-=!+[]+!![]+!![]+!![]+!![]+!![]+!![]+!![]+!![];WvlQzUV.LBvwmvD-=+((!+[]+!![]+!![]+[])+(!+[]+!![]+!![]+!![]+!![]+!![]+!![]+!![]));WvlQzUV.LBvwmvD+=+((!+[]+!![]+!![]+!![]+[])+(!+[]+!![]+!![]));a.value = parseInt(WvlQzUV.LBvwmvD, 10) + t.length; '; 121'
        f.submit();
      }, 4000);
    }, false);
  })();
  //]]>
</script>


</head>
<body>
  <table width=""100%"" height=""100%"" cellpadding=""20"">
    <tr>
      <td align=""center"" valign=""middle"">
          <div class=""cf-browser-verification cf-im-under-attack"">
  <noscript><h1 data-translate=""turn_on_js"" style=""color:#bd2426;"">Please turn JavaScript on and reload the page.</h1></noscript>
  <div id=""cf-content"" style=""display:none"">
    
    <div>
      <div class=""bubbles""></div>
      <div class=""bubbles""></div>
      <div class=""bubbles""></div>
    </div>
    <h1><span data-translate=""checking_browser"">Checking your browser before accessing</span> nga.gov.</h1>
    
    <p data-translate=""process_is_automatic"">This process is automatic. Your browser will redirect to your requested content shortly.</p>
    <p data-translate=""allow_5_secs"">Please allow up to 5 seconds&hellip;</p>
  </div>
   
  <form id=""challenge-form"" action=""/cdn-cgi/l/chk_jschl"" method=""get"">
    <input type=""hidden"" name=""jschl_vc"" value=""c7b24010b1b39b09aed262c5f9b9ed80""/>
    <input type=""hidden"" name=""pass"" value=""1505539303.721-tHbFXU4kQq""/>
    <input type=""hidden"" id=""jschl-answer"" name=""jschl_answer""/>
  </form>
</div>
          
          <div class=""attribution"">
            <a href=""https://www.cloudflare.com/5xx-error-landing?utm_source=iuam"" target=""_blank"" style=""font-size: 12px;"">DDoS protection by Cloudflare</a>
            <br>
            Ray ID: 39f1622f368e2e6f
          </div>
      </td>
     
    </tr>
  </table>
</body>
</html>";

        [Test]
        public void Answer_To_Challenge_Question_Is_108()
        {
            DecodeChallengeQuestion decodeChallengeQuestion = new DecodeChallengeQuestion();
            Assert.AreEqual(108, decodeChallengeQuestion.Decode(NEW_REQUEST_TO_IMAGES_NGA_GOV, "images.nga.gov"));
        }
    }
}