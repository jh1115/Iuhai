<!--
History shows again and again
How nature points out the folly of men
-->
<!DOCTYPE html>
<html lang="en">
   <head>
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width,initial-scale=1">
      <title>Control Collaborative Virtual Machines!</title>
      <meta name="description" content="Control Windows, Linux, and DOS virtual machines from your web browser with complete strangers!"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" integrity="sha384-fLW2N01lMqjakBkx3l/M9EahuwpSfeNvV63J5ezn3uZzapT0u7EYsXMjQV+0En5r" crossorigin="anonymous">
      <link rel="stylesheet" href="http://ontheotherside.cyou/main (DARK).css">
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js" integrity="sha384-o6l2EXLcx4A+q7ls2O2OP2Lb2W7iBgOsYvuuRI6G+Efbjbk6J4xbirJpHZZoHbfs" crossorigin="anonymous"></script><script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" integrity="sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7xS" crossorigin="anonymous"></script><script src="http://ontheotherside.cyou/all.min.js"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/dompurify/2.2.7/purify.min.js" integrity="sha512-srKA/HGYuusMcB2uqsvHKmqqE39vHU74WIuPBaKS5+wtfI6NquGXQtby+eM7o139a7Gt3szcHS09wou8GK4IJQ==" crossorigin="anonymous"></script>
   </head>
   <body>
      <nav class="navbar navbar-default navbar-static-top">
         <div class="container-fluid">
<!--            <div class="navbar-header">
               <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse"><span class="icon-bar"></span> <span class="icon-bar"></span> <span class="icon-bar"></span></button>
               <div class="navbar-brand" style="cursor:default">adminsdietwi.ce</div>
            </div>-->
            <div class="collapse navbar-collapse">
               <ul class="nav navbar-nav">
                  <li><a href="#" onclick="location.reload(); false" id="home-btn">Home</a></li>
                  <li><a href="https://discord.gg/SQvWTnyyTM" target="_blank">Addon Discord</a></li>
                  <li><a href="https://reddit.com/r/collabvm" target="_blank">Subreddit</a></li>
                  <li><a href="https://github.com/r3muxd/tunnel-fixer" target="_blank">Source Code</a></li>
                 <!-- <li>
                     <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Themes <span class="caret"></span></a>
                     <ul class="dropdown-menu">
                        <li><a href="/collab-vm">Light (default)</a></li>
                        <li><a href="/collab-vm/classic">Classic</a></li>
                        <li><a href="/collab-vm/themes/dark-metro">Dark Metro</a></li>
                        <li><a href="/collab-vm/themes/embedded">Embedded</a></li>
                        <li><a href="/collab-vm/themes/experimental">Experimental</a></li>
                        <li><a href="/collab-vm/themes/material">Material</a></li>
                        <li><a href="/collab-vm/themes/metro">Metro</a></li>
                        <li><a href="/collab-vm/themes/royale">Royale</a></li>
                     </ul>
                  </li>-->
               </ul>
            </div>
         </div>
      </nav>
      <div class="modal fade" id="username-modal" tabindex="-1" role="dialog" aria-labelledby="username-modal-label">
         <div class="modal-dialog" role="document">
            <div class="modal-content">
               <div class="modal-header">
                  <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                  <h4 class="modal-title" id="username-modal-label">Change Username</h4>
               </div>
               <div class="modal-body">
                  Enter a new username.<br>
                  <div class="input-group"><span class="input-group-addon" id="username-addon">Username</span> <input type="text" class="form-control" aria-describedby="username-addon" id="username-box"></div>
               </div>
               <div class="modal-footer"><button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button> <button type="button" class="btn btn-primary" id="username-ok-btn">OK</button></div>
            </div>
         </div>
      </div>
      <div class="container-fluid">
        <!-- <div id="loading" style="text-align:center;width:100%;height:100%;position:fixed;display:none">
            <div style="width:10%;height:10vw;position:absolute;display:inline-table;margin-left:-10vw">
               <div class="sk-fading-circle">
                  <div class="sk-circle1 sk-circle"></div>
                  <div class="sk-circle2 sk-circle"></div>
                  <div class="sk-circle3 sk-circle"></div>
                  <div class="sk-circle4 sk-circle"></div>
                  <div class="sk-circle5 sk-circle"></div>
                  <div class="sk-circle6 sk-circle"></div>
                  <div class="sk-circle7 sk-circle"></div>
                  <div class="sk-circle8 sk-circle"></div>
                  <div class="sk-circle9 sk-circle"></div>
                  <div class="sk-circle10 sk-circle"></div>
                  <div class="sk-circle11 sk-circle"></div>
                  <div class="sk-circle12 sk-circle"></div>
               </div>
            </div>
         </div>-->
		 <!--
         <h4 id="warning" style="display:none">
            <div id="warn-text" style="display:none">
               <h2>Warning</h2>
               As anyone can do anything on these PCs, this site may contain NSFW content.<br>
               <div class="checkbox"><label><input type="checkbox" id="no-warn-chkbox">Don't warn me again</label><br></div>
               <button class="btn btn-default" id="nsfw-cont-btn">Continue</button>
            </div>
         </h4>
		 -->

         <div id="vm-list" style=""></div>
         <div id="vm-view" style="display:none">
            <div id="display-outer">
               <div id="display"></div>
               <div style="display:none" class="alert alert-info alert-dismissible" role="alert" id="vote-alert">Do you want to reset the VM? <button type="button" class="btn btn-success" id="vote-yes">Yes</button> <button type="button" class="btn btn-danger" id="vote-no">No</button> <button type="button" class="close" aria-label="Close" id="vote-dismiss"><span aria-hidden="true">&times;</span></button></div>
               <div style="display:none" id="vote-stats">
                  <h3><small>Votes for VM Reset (<span id="vote-time"></span>)</small></h3>
                  <h4><span class="label label-success">Yes: <span id="vote-label-yes"></span></span> <span class="label label-danger">No: <span id="vote-label-no"></span></span></h4>
               </div>
               <div>
                  
				<button class="btn btn-default" type="button" id="turn-btn">Take Turn</button>
				<button style="display:none;" class="btn btn-default" type="button" id="end-turn-btn">End Turn</button><button class="btn btn-default" type="button" id="osk-btn">Keyboard</button><button class="btn btn-default" type="button" data-toggle="modal" data-target="#username-modal" id="username-btn" disabled="disabled">Change Username</button> <button style="display:none" class="btn btn-default" type="button" id="vote-btn">Vote for Reset</button> <button class="btn btn-default" type="button" id="upload-options-btn">Upload File</button>
                  <div id="file-upload" class="form-inline" style="display:none">
                     <br>
                     <center><input class="form" id="upload-input" type="file"></center>
                     <label><input type="checkbox" id="upload-run-chkbox" checked="checked">Run file</label><br><button class="btn btn-default" type="button" id="upload-btn" disabled="disabled">Upload</button>
                     <div id="upload-wait-time"></div>
                  </div>
               </div>
               <h3 style="height:1em"><small id="status"></small></h3>
            </div>
            <div id="kbd-container">
               <div class="osk" id="kbd-outer" style="display:none">
                  <div class="osk" id="kbd-keys"></div>
                  <br>
               </div>
            </div>
            <div class="row">
               <div class="col-md-4">
                  <div class="panel panel-default">
                     <ul class="list-group">
                        <li class="list-group-item disabled" style="cursor:default">Users Online: <span id="users-online"></span></li>
                        <div id="online-users" style="overflow-y:auto;max-height:200px"></div>
                     </ul>
                  </div>
               </div>
               <div class="col-md-8">
                  <div style="position:relative;min-height:200px;margin-bottom:5px">
                     <ul id="chat-panel" class="list-group-item message-pane-wrapper">
                        <div id="chat-box" class="message-pane"></div>
                     </ul>
                  </div>
                  <div class="input-group"><span id="chat-user" class="input-group-addon" style="display:none"></span> <input id="chat-input" type="text" class="form-control" aria-describedby="user-label" disabled="disabled"> <span class="input-group-btn"><button id="chat-send-btn" class="btn btn-default" type="button" disabled="disabled">Send</button> <button type="button" class="btn btn-default" id="chat-sound-btn" title="Toggle chat sound. Not VM sound. The VM does not have sound."><span class="glyphicon glyphicon-volume-up" aria-hidden="true"></span></button></span></div>
               </div>
            </div>
            <br>
         </div>
      </div>
   </body> <script>
 var chatbox=document.getElementById('chat-box')
var chatinput=document.getElementById('chat-input')

if(chatbox){

var changedusers=[]
var sentmessages=[]
var sentindex=-1
var lastdiv

// Detect changes in chat
new MutationObserver(function(mutations){
	mutations.forEach(function(mutation){
		for(var i=0;i<mutation.addedNodes.length;i++){
			var thisnode=mutation.addedNodes[i]
			if(thisnode.getElementsByClassName('username')[0]){
				var textnode=thisnode.firstChild.lastChild
				textnode.nodeValue=textnode.nodeValue.replace(/(\\x[\da-f]{2}|\\u[\da-f]{4}|\\u{1[\da-f]{4}})+/g,function(){
					return eval('"'+arguments[0]+'"')
				})
			}
		}
	})
}).observe(chatbox,{childList:1})

chatinput.maxLength=maxChatMsgLen
chatinput.onkeydown=function(event){
	if(event.keyCode==13){ // Enter
		event.preventDefault()
		event.currentTarget.value=event.currentTarget.value.replace(/[^\da-z`~!@#$%^&*()\-_=+[\]{};'\\:"|,.\/<>? ]+/gi,jsesc).slice(0,maxChatMsgLen)
		document.getElementById('chat-send-btn').click()
	}
}

function blurchat(){
	var canvas=document.querySelector('#display>div>div>div')
	if(canvas&&!canvas.onmousedown){
		canvas.onmousedown=function(){
			document.getElementById('chat-input').blur()
		}
	}
}
blurchat()
setInterval(blurchat,500)

}
loginTimesPressed = 0
var style=document.createElement('style')
style.appendChild(document.createTextNode('#display :not(:first-child){pointer-events:none}'))
document.head.appendChild(style)

function jsesc(argument){
	var result=''
	for(var i=0;i<argument.length;i++){
		var character=argument.charAt(i)
		var first=argument.charCodeAt(i)
		if(first>=55296&&first<=56319&&argument.length>i+1){
			var second=argument.charCodeAt(i+1)
			if(second>=56320&&second<=57343){
				var hex=((first-55296)*1024+second-56320+65536).toString(16)
				result+='\\u{'+hex+'}'
				i++
				continue
			}
		}
		var hex=character.charCodeAt(0).toString(16)
		var longhand=hex.length>2
		result+='\\'+(longhand?'u':'x')+('0000'+hex).slice(longhand?-4:-2)
	}
	return result
}
</script>
<script>
console.log('%cHi there. If you find a bug or an exploit, please report it to me at r3muxd@gmail.com. It\'d be really appreciated. Thank you!', 'background: #000; color: #32cd32');
</script>
<script>
    var listofnodes = []
    setTimeout(function() {
        multicollab('computernewb.com:6004')
        multicollab('computernewb.com:6005')
        multicollab('computernewb.com:6006')
        multicollab('computernewb.com:6007')
        multicollab('computernewb.com:6008')
        additionalNodes = ["18.222.150.4:6004", "177.159.234.74:6004", "home.funshitposting.xyz:6004", "home.darkok.xyz:6004", "darkok.xyz:3037", "198.58.119.51:6004", "198.58.119.51:6005", "198.58.119.51:6006", "35.225.155.122:6004", "35.227.76.255:6004", "35.227.76.255:6005", "35.227.76.255:6006", "35.227.76.255:6007", "40.121.10.217:6004", "5.71.224.138:6004", "209.141.57.90:6004", "computernewb.com:7777", "144.202.56.90:6004", "vmland.ml:2095", "104.219.234.139:6004", "pkjx.xyz:6004", "109.255.230.173:6004", "collabvm2.ddns.net:80", "dedi.miklosakos.eu:6004"]
	for(var i in additionalNodes){multicollab(additionalNodes[i])}
        //multicollab('computernewb.com:6004')
        //multicollab('computernewb.com:6005')
//        multicollab('173.208.236.234:6006')
        //multicollab('63.141.238.98:6004')
        //multicollab('63.141.238.98:6005')
    }, 250)
    function multicollab(ip) {
        var tunnel2 = new Guacamole.WebSocketTunnel('ws://' + ip + '/')
        tunnel2.onstatechange = function(code) {
            if (code == 2) {
                setTimeout(function() {
                    guac2.connect()
                }, 1000)
            } else if (code == 1) {
                tunnel2.sendMessage('connect')
                tunnel2.sendMessage('list')
            }
        }
        var guac2 = new Guacamole.Client(tunnel2)
        guac2.onlist = function(e) {
            tunnel2.onstatechange = null
            guac2.disconnect()
            for (var i = 0; i < e.length; i += 3) {
                listofnodes.push({
                    ip: ip,
                    url: e[i],
                    name: e[i + 1],
                    image: e[i + 2]
                })
            }
            updateVMList2()
        }
        guac2.connect()
    }
    function updateVMList2() {
        listofnodes.sort(function(a, b) {
            return a.url > b.url ? 1 : -1
        })
        var vmlist = document.getElementById('vm-list')
        vmlist.innerHTML = ''
        for (var i in listofnodes) {
            (function() {
                var thisnode = listofnodes[i]
                var div = document.createElement('div')
                div.className = 'col-sm-5 col-md-3'
                var link = document.createElement('a')
                link.className = 'thumbnail'
                link.href = '#view/' + thisnode.url
				var sanitizedcaption = DOMPurify.sanitize(thisnode.name, {USE_PROFILES: {html: true}});
                link.innerHTML = (thisnode.image ? '<img src="data:image/png;base64,' + thisnode.image + '"/>' : '<img src="http://computernewb.com/screenshots/' + thisnode.url + '.jpg"/>') + '<div class="caption"><h4>' + sanitizedcaption + '</h4></div>';
                link.onclick = function(event) {
                    event.preventDefault()
                    tunnel.onstatechange = null
                    guac.disconnect()
                    var display = document.getElementById('display')
					if(display.firstChild)
                    display.removeChild(display.firstChild)
                    window.tunnel = new Guacamole.WebSocketTunnel('ws://' + thisnode.ip + '/')
                    window.guac = new Guacamole.Client(tunnel)
                    window.vmName = thisnode.url
                    window.serverAddress = thisnode.ip
                    DartzCodingTM()
                }
                div.appendChild(link)
                vmlist.appendChild(div)
            })()
        }
    }
    function DartzCodingTM() {
        window.waitingTimer = function(e, t, n) {
            var a, r = "", o = function() {
                var n = Math.floor(t / 1e3);
                0 >= n ? (clearInterval(a),
                e(null )) : (r.length < 3 ? r += "." : r = "",
                e(n, r))
            }
            ;
            return o(),
            a = setInterval(function() {
                t -= 1e3,
                o()
            }, 1e3)
        }
        guac.getDisplay().getElement().addEventListener("click", function() {
            hasTurn || tunnel.sendMessage("turn")
        })
        guac.onerror = function(e) {
            debugLog(e)
        }
        tunnel.onstatechange = function(e) {
            if (e == Guacamole.Tunnel.State.CLOSED) {
                displayLoading(),
                displayVMList(!1),
                $("#username-btn").prop("disabled", !0),
                activateOSK(!1);
                var t = guac.getDisplay().getElement();
                t.parentNode == display && display.removeChild(t),
                $("#vm-list").empty(),
                connected = !1,
                users = [],
                usersWaiting = 0,
                usersData = {},
                n = null ,
                setFocus(!1),
                hasTurn = !1,
                null !== turnInterval && (clearInterval(turnInterval),
                turnInterval = null ,
                $("#status").html("")),
                null !== voteInterval && (clearInterval(voteInterval),
                voteInterval = null ),
                display.className = "",
                displayTable(),
                $("#chat-send-btn").prop("disabled", !0),
                $("#chat-input").prop("disabled", !0),
                $("#chat-user").hide().html(""),
                setTimeout(function() {
                    tunnel.state = Guacamole.Tunnel.State.CONNECTING,
                    guac.connect()
                }, 1e4)
            } else if (e == Guacamole.Tunnel.State.OPEN) {
                hasVoted = !1,
                displayLoading();
                var n = getCookie("username");
                n ? tunnel.sendMessage("rename", n) : tunnel.sendMessage("rename"),
                vmName ? tunnel.sendMessage("connect", vmName) : (displayVMList(),
                tunnel.sendMessage("list")),
                display.appendChild(guac.getDisplay().getElement()),
                $("#chat-send-btn").prop("disabled", !1),
                $("#chat-input").prop("disabled", !1),
                $("#chat-user").show()
            }
        }
        guac.onlist = function(e) {
            updateVMList(e),
            displayLoading(!1)
        }


	$("#chat-user").click(() => {
		++loginTimesPressed;

		if (loginTimesPressed == 4) {
			location.href = "https://www.youtube.com/watch?v=sZ604QDpSmw"
		}
		setTimeout(()=>{
			admin.loginTimesPressed = 0;
		}, 1500);
	});
        guac.onturn = function(parameters) {
		debugLog("Turn: ");
		debugLog(parameters);
		// Clear all user data
		for (var i = 0; i < users.length; i++)
			usersData[users[i]][1] = 0;

		usersWaiting = parseInt(parameters[1]);
		var num = usersWaiting + 2;
		for (var i = 2; i < num; i++) {
			usersData[parameters[i]][1] = i-1;
		}
		if (num > 2 && parameters[2] == username) {
			// The user has control
			hasTurn = true;
			$("#turn-btn").hide();
			$("#end-turn-btn").show();
			
			display.className = "focused";
			if (turnInterval !== null)
				clearInterval(turnInterval);
			// Round the turn time up to the nearest second
			turnInterval = waitingTimer(function(seconds) {
					if (seconds !== null) {
						$("#status").html("Your turn expires " + "in ~" + seconds + " seconds");
					} else {
						turnInterval = null;
						$("#status").html("");
					}
				}, Math.round(parseInt(parameters[0])/1000)*1000);
		} else if (parameters.length > num) {
			// The user is waiting for control
			hasTurn = false;
			$("#turn-btn").hide();
			$("#end-turn-btn").show();
			display.className = "waiting";
			if (turnInterval !== null)
				clearInterval(turnInterval);
			turnInterval = waitingTimer(function(seconds, dots) {
					if (seconds !== null) {
						$("#status").html("Waiting for turn " + "in ~" + seconds + " seconds" + dots);
					} else {
						turnInterval = null;
						$("#status").html("");
					}
				}, Math.round(parseInt(parameters[parameters.length-1])/1000)*1000);
		} else {
			if (turnInterval !== null || hasTurn) {
				hasTurn = false;
				$("#status").html("");
				$("#turn-btn").show();
				$("#end-turn-btn").hide();
				display.className = "";
				if (turnInterval !== null) {
					clearInterval(turnInterval);
					turnInterval = null;
				}
			}
		}
		activateOSK(hasTurn);
		displayTable();
	}
        guac.onrename = function(e) {
            if ("0" === e[0]) {
                var t = null === username;
                if (!t)
                    for (var n = 0; n < users.length; n++)
                        if (users[n] == username) {
                            users.splice(n, 1);
                            break
                        }
                username = e[2],
                $("#username-btn").prop("disabled", !1),
                $("#chat-user").html(username),
                -1 == $.inArray(username, users) && users.push(username),
                usersData[username] = [0, 0],
                setCookie("username", username, 365),
                "1" === e[1] ? alert("That username is already taken.") : "2" === e[1] && alert("Usernames can contain only numbers, letters, spaces, dashes, underscores, and dots, and it must be between 3 and 20 characters.")
            } else if ("1" === e[0]) {
                for (var a = e[1], r = 0; r < users.length; r++)
                    if (users[r] == a) {
                        users[r] = e[2];
                        break
                    }
                usersData[e[2]] = usersData[a],
                delete usersData[a]
            }
            displayTable()
        }
        guac.onconnect = function(e) {
            switch (parseInt(e[0])) {
            case 0:
                alert("Failed to connect to VM.");
                break;
            case 1:
                updateActions(e.slice(1)),
                $("#chat-box").empty(),
                $("#vote-alert").hide(),
                $("#vote-stats").hide(),
                displayVMView(),
                null === username && tunnel.sendMessage("rename", getCookie("username")),
                connected = !0,
                displayLoading(!1);
                break;
            case 2:
                connected = !1,
                hasTurn = !1,
                null !== turnInterval && clearInterval(turnInterval),
                null !== voteInterval && clearInterval(voteInterval),
                null !== uploadInterval && clearInterval(uploadInterval),
                History.pushState(null , null , rootDir)
            }
        }
        guac.onadduser = function(e) {
            debugLog("Add user: "),
            debugLog(e);
            for (var t = 2 * parseInt(e[0]) + 1, n = 1; t > n; n += 2)
                e[n] !== username && (users.push(e[n]),
                usersData[e[n]] = [parseInt(e[n + 1]), 0]);
            displayTable()
        }
        guac.onremuser = function(e) {
            debugLog("Remove user: "),
            debugLog(e);
            for (var t = parseInt(e[0]) + 1, n = 1; t > n; n++) {
                for (var a = e[n], r = 0; r < users.length; r++)
                    if (users[r] == a) {
                        users.splice(r, 1);
                        break
                    }
                delete usersData[a]
            }
            displayTable()
        }
        guac.onchat = function(e) {
            for (var t = 0; t < e.length; t += 2)
                chatMessage(e[t], e[t + 1])
        }
        guac.onvote = function(e) {
            switch (parseInt(e[0])) {
            case 0:
                debugLog("Vote started");
            case 1:
                debugLog("Update vote stats"),
                setVoteStats(e);
                break;
            case 2:
                debugLog("Voting ended"),
                $("#vote-alert").hide(),
                $("#vote-stats").hide(),
                hasVoted = !1;
                break;
            case 3:
                alert("Please wait " + e[1] + " seconds before starting another vote.")
            }
        }
        guac.onfile = function(e) {
            switch (parseInt(e[0])) {
            case fileResponse.BEGIN:
                startFileUpload(e[1]);
                break;
            case fileResponse.FINISHED:
                $("#upload-input").val(null ).prop("disabled", !1),
                displayUploadWaitTime(2 === e.length ? parseInt(e[1]) : 0);
                break;
            case fileResponse.WAIT_TIME:
                displayUploadWaitTime(parseInt(e[1]));
                break;
            case fileResponse.FAILED:
                $("#upload-input").val(null ).prop("disabled", !1),
                displayUploadWaitTime(2 === e.length ? parseInt(e[1]) : 0),
                alert("File upload failed");
                break;
            case fileResponse.TIMED_OUT:
                $("#upload-input").val(null ).prop("disabled", !1),
                displayUploadWaitTime(2 === e.length ? parseInt(e[1]) : 0),
                alert("File upload timed out");
                break;
            case fileResponse.UPLOAD_IN_PROGRESS:
                $("#upload-btn, #upload-input").prop("disabled", !0)
            }
        }
        guac.onaction = function(e) {
            updateActions(e)
        }
        document.addEventListener("mousedown", function() {
            focused && setFocus(!1)
        })
        mouse = new ("ontouchstart"in document ? Guacamole.Mouse.Touchscreen : Guacamole.Mouse)(guac.getDisplay().getElement())
        mouse.onmousedown = function(e) {
            focused || setFocus(!0),
            hasTurn && guac.sendMouseState(e)
        }
        mouse.onmouseup = mouse.onmousemove = function(e) {
            hasTurn && guac.sendMouseState(e)
        }
        keyboard = new Guacamole.Keyboard(document)
        guac.connect()
	}

    
</script>
<noscript><p><center>JavaScript is required to use CollabVM. Either your browser is too old to run this website or you have disabled JavaScript from running.</center></p></noscript>
<noscript><p><center>Please enable JavaScript in your browser and try again. If you still cannot connect, please try a newer browser (or try disabling some extensions) and try again.</center></p></noscript>
