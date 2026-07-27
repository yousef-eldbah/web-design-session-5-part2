// ===== GLOBAL INTERACTION SCRIPTS FOR SESSION 15 =====

document.addEventListener('DOMContentLoaded', () => {
  initCollapsibles();
  initCodeCopy();
  initProgressObserver();
  initFlexSandbox();
  initHidingSandbox();
  initBgSandbox();
});

// ===== HAMBURGER & SIDEBAR MOBILE INTERACTION =====
function toggleSidebar() {
  const sidebar = document.getElementById('sidebar');
  if (sidebar) {
    sidebar.classList.toggle('open');
  }
}

// Close sidebar on link click (mobile devices)
document.querySelectorAll('.sidebar-link').forEach(link => {
  link.addEventListener('click', () => {
    const sidebar = document.getElementById('sidebar');
    if (sidebar && window.innerWidth <= 850) {
      sidebar.classList.remove('open');
    }
  });
});

// ===== SEARCH FILTER IN SIDEBAR =====
function filterTopics() {
  const q = document.getElementById('searchInput').value.toLowerCase();
  document.querySelectorAll('.sidebar-link').forEach(l => {
    const text = l.textContent.toLowerCase();
    l.style.display = text.includes(q) ? '' : 'none';
  });
}

// ===== PROGRESS BAR & SCROLLING ACTIVE LINK STATE =====
function initProgressObserver() {
  window.addEventListener('scroll', () => {
    const h = document.documentElement;
    const scrollHeight = h.scrollHeight - h.clientHeight;
    const pct = scrollHeight > 0 ? Math.round((h.scrollTop / scrollHeight) * 100) : 0;
    
    const pBar = document.getElementById('progressBar');
    const pText = document.getElementById('progressText');
    
    if (pBar) pBar.style.width = pct + '%';
    if (pText) pText.textContent = pct + '% Complete';
    
    // Auto-update active sidebar link depending on current scroll position
    let currentId = '';
    const scrollPosition = window.scrollY + 120; // threshold offset
    
    document.querySelectorAll('section[id], div[id].topic-section, section[id].hero, div[id].project-wrapper').forEach(section => {
      const sectionTop = section.offsetTop;
      if (scrollPosition >= sectionTop) {
        currentId = section.getAttribute('id');
      }
    });
    
    if (currentId) {
      document.querySelectorAll('.sidebar-link').forEach(l => {
        l.classList.toggle('active', l.getAttribute('href') === '#' + currentId);
      });
    }
  });
}

// ===== CODE BLOCK COPY BUTTON HELPER =====
function initCodeCopy() {
  document.querySelectorAll('.code-copy').forEach(btn => {
    btn.addEventListener('click', () => {
      const pre = btn.parentElement.nextElementSibling;
      if (pre && pre.tagName === 'PRE') {
        const text = pre.innerText;
        navigator.clipboard.writeText(text).then(() => {
          btn.textContent = 'Copied!';
          btn.classList.add('copied');
          setTimeout(() => {
            btn.textContent = 'Copy';
            btn.classList.remove('copied');
          }, 1500);
        }).catch(err => {
          console.error('Could not copy text: ', err);
        });
      }
    });
  });
}

// ===== COLLAPSIBLE ACCORDION FOR EXERCISES & SOLUTIONS =====
function initCollapsibles() {
  document.querySelectorAll('.collapsible-header').forEach(header => {
    header.addEventListener('click', () => {
      const collapsible = header.parentElement;
      collapsible.classList.toggle('open');
      const body = header.nextElementSibling;
      if (collapsible.classList.contains('open')) {
        body.style.maxHeight = body.scrollHeight + 'px';
      } else {
        body.style.maxHeight = '0px';
      }
    });
  });
}

// ===== INTERACTIVE QUIZ OPTION SELECT STATE =====
function checkAnswer(el, isCorrect) {
  // Check if options are already locked (already selected)
  const parent = el.parentElement;
  if (parent.style.pointerEvents === 'none') return;
  
  // Highlight the selected element
  if (isCorrect) {
    el.classList.add('correct');
  } else {
    el.classList.add('wrong');
    // Find and highlight the correct element too
    parent.querySelectorAll('.quiz-option').forEach(option => {
      if (option.getAttribute('onclick').includes('true')) {
        option.classList.add('correct');
      }
    });
  }
  
  // Disable pointer events to prevent changing choice
  parent.style.pointerEvents = 'none';
}

// ===== TOPIC 1: FLEXBOX CHILD PROPERTIES SANDBOX CONTROLLER =====
function initFlexSandbox() {
  const item1 = document.getElementById('flexItem1');
  const item2 = document.getElementById('flexItem2');
  const item3 = document.getElementById('flexItem3');
  
  if (!item1 || !item2 || !item3) return;
  
  // Elements of sliders
  const sliders = {
    // Item 1
    order1: document.getElementById('order1'),
    grow1: document.getElementById('grow1'),
    shrink1: document.getElementById('shrink1'),
    basis1: document.getElementById('basis1'),
    
    // Item 2
    order2: document.getElementById('order2'),
    grow2: document.getElementById('grow2'),
    shrink2: document.getElementById('shrink2'),
    basis2: document.getElementById('basis2'),
    
    // Item 3
    order3: document.getElementById('order3'),
    grow3: document.getElementById('grow3'),
    shrink3: document.getElementById('shrink3'),
    basis3: document.getElementById('basis3')
  };
  
  function updateFlexSandbox() {
    // Update Item 1 Styles and text details
    item1.style.order = sliders.order1.value;
    item1.style.flexGrow = sliders.grow1.value;
    item1.style.flexShrink = sliders.shrink1.value;
    item1.style.flexBasis = sliders.basis1.value;
    
    document.getElementById('val-order1').textContent = sliders.order1.value;
    document.getElementById('val-grow1').textContent = sliders.grow1.value;
    document.getElementById('val-shrink1').textContent = sliders.shrink1.value;
    document.getElementById('val-basis1').textContent = sliders.basis1.value;
    
    // Update Item 2 Styles and text details
    item2.style.order = sliders.order2.value;
    item2.style.flexGrow = sliders.grow2.value;
    item2.style.flexShrink = sliders.shrink2.value;
    item2.style.flexBasis = sliders.basis2.value;
    
    document.getElementById('val-order2').textContent = sliders.order2.value;
    document.getElementById('val-grow2').textContent = sliders.grow2.value;
    document.getElementById('val-shrink2').textContent = sliders.shrink2.value;
    document.getElementById('val-basis2').textContent = sliders.basis2.value;
    
    // Update Item 3 Styles and text details
    item3.style.order = sliders.order3.value;
    item3.style.flexGrow = sliders.grow3.value;
    item3.style.flexShrink = sliders.shrink3.value;
    item3.style.flexBasis = sliders.basis3.value;
    
    document.getElementById('val-order3').textContent = sliders.order3.value;
    document.getElementById('val-grow3').textContent = sliders.grow3.value;
    document.getElementById('val-shrink3').textContent = sliders.shrink3.value;
    document.getElementById('val-basis3').textContent = sliders.basis3.value;
    
    // Write dynamic styles inside details labels inside divs
    item1.querySelector('.item-details').innerHTML = 
      `order: ${sliders.order1.value}<br>grow: ${sliders.grow1.value}<br>shrink: ${sliders.shrink1.value}<br>basis: ${sliders.basis1.value}`;
    
    item2.querySelector('.item-details').innerHTML = 
      `order: ${sliders.order2.value}<br>grow: ${sliders.grow2.value}<br>shrink: ${sliders.shrink2.value}<br>basis: ${sliders.basis2.value}`;
      
    item3.querySelector('.item-details').innerHTML = 
      `order: ${sliders.order3.value}<br>grow: ${sliders.grow3.value}<br>shrink: ${sliders.shrink3.value}<br>basis: ${sliders.basis3.value}`;
  }
  
  // Attach change listener to all sliders
  Object.values(sliders).forEach(slider => {
    if (slider) {
      slider.addEventListener('input', updateFlexSandbox);
    }
  });
  
  // Initial run
  updateFlexSandbox();
}

// ===== TOPIC 2: HIDING ELEMENTS SANDBOX CONTROLLER =====
function initHidingSandbox() {
  const target = document.getElementById('hideTarget');
  const output = document.getElementById('hideOutput');
  const buttons = document.querySelectorAll('.hide-btn');
  
  if (!target || !output) return;
  
  buttons.forEach(btn => {
    btn.addEventListener('click', () => {
      // Toggle active state among buttons
      buttons.forEach(b => b.classList.remove('active'));
      btn.classList.add('active');
      
      const action = btn.dataset.action;
      
      // Remove all hiding classes
      target.classList.remove('hide-display-none', 'hide-visibility-hidden', 'hide-opacity-0', 'hide-pointer-events-none');
      
      // Reset clicking test
      target.onclick = () => {
        alert("🎉 Clicked Target Box! Element is accessible!");
      };
      
      let description = '';
      
      switch (action) {
        case 'none':
          description = '// Element is completely visible.\n// Takes space: YES\n// Clickable: YES\n// Layout impact: Normal rendering';
          break;
        case 'display':
          target.classList.add('hide-display-none');
          description = '// element.style.display = "none";\n// Takes space: NO (Layout updates and collapses)\n// Clickable: NO\n// Transitions: Does NOT work';
          target.onclick = null;
          break;
        case 'visibility':
          target.classList.add('hide-visibility-hidden');
          description = '// element.style.visibility = "hidden";\n// Takes space: YES (Blank space remains)\n// Clickable: NO\n// Transitions: Works partially (discrete status switch)';
          target.onclick = null;
          break;
        case 'opacity':
          target.classList.add('hide-opacity-0');
          description = '// element.style.opacity = "0";\n// Takes space: YES (Takes layout space)\n// Clickable: YES (Can still click empty space! Click it below!)\n// Transitions: YES (Fully animated)';
          break;
        case 'pointer':
          target.classList.add('hide-pointer-events-none');
          description = '// element.style.pointerEvents = "none";\n// Takes space: YES (Visible but clicks pass through to underneath layers)\n// Clickable: NO (Clicks are blocked)\n// Transitions: YES';
          target.onclick = null;
          break;
      }
      
      output.textContent = description;
    });
  });
}

// ===== TOPIC 4: BACKGROUND & OBJECT-FIT SANDBOX =====
function initBgSandbox() {
  const bgPreview = document.getElementById('bgSandboxPreview');
  const fitImg = document.getElementById('fitSandboxImg');
  
  if (!bgPreview || !fitImg) return;
  
  // Background Size Toggle
  window.changeBgSize = function(size) {
    bgPreview.style.backgroundSize = size;
    const desc = bgPreview.querySelector('.bg-sandbox-overlay-text');
    desc.textContent = `background-size: ${size};`;
  };
  
  // Background Repeat Toggle
  window.changeBgRepeat = function(repeat) {
    bgPreview.style.backgroundRepeat = repeat;
  };
  
  // Object-fit Option Toggle
  window.changeObjectFit = function(fit) {
    fitImg.style.objectFit = fit;
    const fitLabel = document.getElementById('fitLabel');
    if (fitLabel) fitLabel.textContent = fit;
  };
}
