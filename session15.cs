/* ===== CSS RESET & ROOT VARIABLES ===== */
*, *::before, *::after {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

:root {
  /* Colors - Cyberpunk/Glassmorphic Dark Theme */
  --bg-primary: #0a0a1c;
  --bg-secondary: #11112b;
  --bg-card: rgba(255, 255, 255, 0.03);
  --bg-glass: rgba(255, 255, 255, 0.05);
  --bg-glass-hover: rgba(255, 255, 255, 0.09);
  
  --text-primary: #f1f1f7;
  --text-secondary: #a2a2ca;
  --text-muted: #6b6b8b;
  
  --accent-blue: #4f46e5;
  --accent-purple: #9333ea;
  --accent-pink: #db2777;
  --accent-cyan: #06b6d4;
  --accent-green: #10b981;
  --accent-orange: #f59e0b;
  --accent-red: #ef4444;
  
  --gradient-primary: linear-gradient(135deg, #4f46e5, #9333ea, #db2777);
  --gradient-secondary: linear-gradient(135deg, #06b6d4, #10b981);
  --gradient-warning: linear-gradient(135deg, #f59e0b, #ef4444);
  
  --border-color: rgba(255, 255, 255, 0.07);
  --border-glass: rgba(255, 255, 255, 0.12);
  
  --radius-sm: 8px;
  --radius-md: 12px;
  --radius-lg: 16px;
  --radius-xl: 24px;
  
  --shadow-glow: 0 0 30px rgba(79, 70, 229, 0.15);
  --shadow-glow-cyan: 0 0 30px rgba(6, 182, 212, 0.15);
  
  --sidebar-width: 290px;
  --navbar-height: 70px;
  
  --font-main: 'Inter', sans-serif;
  --font-mono: 'JetBrains Mono', monospace;
  --font-arabic: 'Cairo', sans-serif;
}

html {
  scroll-behavior: smooth;
  font-size: 16px;
  scrollbar-width: thin;
  scrollbar-color: var(--accent-blue) var(--bg-secondary);
}

body {
  font-family: var(--font-main);
  background: var(--bg-primary);
  color: var(--text-primary);
  line-height: 1.7;
  overflow-x: hidden;
}

/* Scrollbar Customization */
::-webkit-scrollbar {
  width: 8px;
  height: 8px;
}
::-webkit-scrollbar-track {
  background: var(--bg-secondary);
}
::-webkit-scrollbar-thumb {
  background: var(--accent-blue);
  border-radius: 4px;
}
::-webkit-scrollbar-thumb:hover {
  background: var(--accent-purple);
}

::selection {
  background: rgba(79, 70, 229, 0.35);
  color: #fff;
}

a {
  color: var(--accent-cyan);
  text-decoration: none;
  transition: all 0.3s ease;
}
a:hover {
  color: var(--accent-purple);
}

/* ===== NAVBAR ===== */
.navbar {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  height: var(--navbar-height);
  background: rgba(10, 10, 28, 0.85);
  backdrop-filter: blur(25px);
  border-bottom: 1px solid var(--border-color);
  z-index: 1000;
  display: flex;
  align-items: center;
  padding: 0 24px;
  gap: 16px;
}

.navbar-brand {
  display: flex;
  align-items: center;
  gap: 12px;
  font-weight: 850;
  font-size: 1.15rem;
  letter-spacing: -0.5px;
}

.navbar-brand .logo {
  width: 38px;
  height: 38px;
  background: var(--gradient-primary);
  border-radius: 12px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 1.2rem;
  font-weight: 900;
  color: #fff;
  box-shadow: 0 4px 15px rgba(79, 70, 229, 0.3);
}

.navbar-brand span {
  background: var(--gradient-primary);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.navbar-center {
  flex: 1;
  display: flex;
  justify-content: center;
}

.navbar-search {
  background: var(--bg-glass);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-md);
  padding: 10px 18px;
  color: var(--text-primary);
  font-size: 0.9rem;
  width: 350px;
  max-width: 100%;
  outline: none;
  transition: all 0.3s ease;
}

.navbar-search:focus {
  border-color: var(--accent-blue);
  box-shadow: 0 0 0 3px rgba(79, 70, 229, 0.15);
  background: rgba(255, 255, 255, 0.08);
}

.nav-badge {
  background: var(--gradient-primary);
  color: #fff;
  padding: 5px 14px;
  border-radius: 20px;
  font-size: 0.78rem;
  font-weight: 700;
  box-shadow: 0 2px 8px rgba(219, 39, 119, 0.2);
}

.hamburger {
  display: none;
  background: none;
  border: none;
  color: var(--text-primary);
  font-size: 1.6rem;
  cursor: pointer;
  padding: 6px;
  border-radius: var(--radius-sm);
  transition: background 0.2s;
}

.hamburger:hover {
  background: var(--bg-glass);
}

/* ===== SIDEBAR ===== */
.sidebar {
  position: fixed;
  top: var(--navbar-height);
  left: 0;
  width: var(--sidebar-width);
  height: calc(100vh - var(--navbar-height));
  background: rgba(17, 17, 43, 0.96);
  backdrop-filter: blur(15px);
  border-right: 1px solid var(--border-color);
  overflow-y: auto;
  padding: 24px 0;
  z-index: 900;
  transition: transform 0.3s ease;
}

.sidebar-progress {
  margin: 0 20px 24px;
  padding: 18px;
  background: var(--bg-glass);
  border-radius: var(--radius-lg);
  border: 1px solid var(--border-color);
}

.progress-bar-container {
  height: 6px;
  background: rgba(255, 255, 255, 0.07);
  border-radius: 3px;
  overflow: hidden;
  margin-top: 10px;
}

.progress-bar-fill {
  height: 100%;
  background: var(--gradient-primary);
  border-radius: 3px;
  transition: width 0.4s ease;
  width: 0%;
}

.progress-text {
  font-size: 0.75rem;
  color: var(--text-muted);
  margin-top: 6px;
  display: block;
}

.sidebar-section {
  padding: 0 16px;
  margin-bottom: 28px;
}

.sidebar-title {
  font-size: 0.72rem;
  font-weight: 700;
  text-transform: uppercase;
  letter-spacing: 1.8px;
  color: var(--text-muted);
  margin-bottom: 10px;
  padding: 0 12px;
}

.sidebar-link {
  display: flex;
  align-items: center;
  gap: 12px;
  padding: 10px 14px;
  border-radius: var(--radius-md);
  color: var(--text-secondary);
  font-size: 0.88rem;
  font-weight: 550;
  cursor: pointer;
  transition: all 0.25s ease;
}

.sidebar-link:hover {
  background: var(--bg-glass-hover);
  color: var(--text-primary);
}

.sidebar-link.active {
  background: rgba(79, 70, 229, 0.16);
  color: var(--text-primary);
  border-left: 4px solid var(--accent-blue);
  font-weight: 600;
}

.sidebar-link .icon {
  font-size: 1.05rem;
  width: 22px;
  text-align: center;
}

/* ===== MAIN CONTENT ===== */
.main-content {
  margin-left: var(--sidebar-width);
  margin-top: var(--navbar-height);
  padding: 48px 56px;
  max-width: calc(100% - var(--sidebar-width));
  min-height: 100vh;
  transition: all 0.3s ease;
}

.content-wrapper {
  max-width: 960px;
  margin: 0 auto;
}

/* ===== HERO ===== */
.hero {
  background: var(--bg-glass);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-xl);
  padding: 54px;
  margin-bottom: 48px;
  position: relative;
  overflow: hidden;
  box-shadow: var(--shadow-glow);
}

.hero::before {
  content: '';
  position: absolute;
  top: -50%;
  right: -20%;
  width: 450px;
  height: 450px;
  background: radial-gradient(circle, rgba(147, 51, 234, 0.15), transparent 70%);
  pointer-events: none;
}

.hero::after {
  content: '';
  position: absolute;
  bottom: -30%;
  left: -10%;
  width: 350px;
  height: 350px;
  background: radial-gradient(circle, rgba(6, 182, 212, 0.12), transparent 70%);
  pointer-events: none;
}

.hero-badge {
  display: inline-flex;
  align-items: center;
  gap: 6px;
  background: rgba(6, 182, 212, 0.14);
  border: 1px solid rgba(6, 182, 212, 0.3);
  color: var(--accent-cyan);
  padding: 7px 15px;
  border-radius: 30px;
  font-size: 0.8rem;
  font-weight: 650;
  margin-bottom: 20px;
}

.hero h1 {
  font-size: 2.8rem;
  font-weight: 900;
  line-height: 1.25;
  margin-bottom: 16px;
  background: linear-gradient(135deg, #06b6d4, #10b981, #9333ea, #db2777);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.hero .subtitle {
  font-size: 1.12rem;
  color: var(--text-secondary);
  margin-bottom: 28px;
  max-width: 700px;
}

.hero-meta {
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
}

.hero-meta-item {
  display: flex;
  align-items: center;
  gap: 8px;
  font-size: 0.88rem;
  color: var(--text-muted);
}

/* ===== INSTRUCTOR ===== */
.instructor-card {
  background: var(--bg-glass);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-xl);
  padding: 36px;
  margin-bottom: 48px;
  display: flex;
  gap: 28px;
  align-items: center;
}

.instructor-avatar {
  width: 90px;
  height: 90px;
  border-radius: 50%;
  background: var(--gradient-primary);
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 2.2rem;
  font-weight: 900;
  color: #fff;
  flex-shrink: 0;
  box-shadow: var(--shadow-glow);
}

.instructor-info h3 {
  font-size: 1.3rem;
  font-weight: 800;
  margin-bottom: 4px;
}

.instructor-info .role {
  color: var(--accent-cyan);
  font-size: 0.95rem;
  font-weight: 600;
  margin-bottom: 8px;
}

.instructor-info .bio {
  color: var(--text-secondary);
  font-size: 0.88rem;
  margin-bottom: 12px;
}

.instructor-tags {
  display: flex;
  flex-wrap: wrap;
  gap: 8px;
}

.instructor-tag {
  background: var(--bg-glass);
  border: 1px solid var(--border-color);
  padding: 4px 12px;
  border-radius: 12px;
  font-size: 0.78rem;
  color: var(--text-secondary);
}

.instructor-link {
  display: inline-block;
  font-size: 0.88rem;
  font-weight: 600;
  color: var(--accent-cyan);
  margin-top: 10px;
  border-bottom: 1px dashed var(--accent-cyan);
  padding-bottom: 2px;
}
.instructor-link:hover {
  color: var(--accent-pink);
  border-color: var(--accent-pink);
}

/* ===== TABLE OF CONTENTS ===== */
.toc-box {
  background: var(--bg-glass);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-lg);
  padding: 28px;
  margin-bottom: 48px;
}

.toc-box h3 {
  font-size: 1.08rem;
  font-weight: 750;
  margin-bottom: 16px;
  color: #fff;
  border-bottom: 1px solid var(--border-color);
  padding-bottom: 10px;
}

.toc-list {
  list-style: none;
  padding: 0;
  display: grid;
  grid-template-columns: 1fr;
  gap: 8px;
}

.toc-list li a {
  color: var(--text-secondary);
  font-size: 0.9rem;
  padding: 6px 12px;
  border-radius: var(--radius-sm);
  display: block;
  transition: all 0.25s ease;
}

.toc-list li a:hover {
  color: var(--accent-cyan);
  background: var(--bg-glass-hover);
  padding-left: 18px;
}

/* ===== LEARNING OBJECTIVES & ROADMAP ===== */
.objectives {
  list-style: none;
  padding: 0;
  display: grid;
  gap: 10px;
}

.objectives li {
  display: flex;
  align-items: flex-start;
  gap: 12px;
  padding: 12px 18px;
  background: var(--bg-glass);
  border-radius: var(--radius-md);
  border: 1px solid var(--border-color);
  font-size: 0.92rem;
  color: var(--text-secondary);
}

.objectives li::before {
  content: '✔';
  color: var(--accent-green);
  font-weight: 800;
  flex-shrink: 0;
}

.roadmap {
  display: flex;
  flex-wrap: wrap;
  gap: 10px;
  align-items: center;
  margin: 20px 0;
  padding: 24px;
  background: var(--bg-glass);
  border-radius: var(--radius-lg);
  border: 1px solid var(--border-color);
}

.roadmap-step {
  padding: 10px 16px;
  background: rgba(6, 182, 212, 0.08);
  border-radius: var(--radius-md);
  border: 1px solid rgba(6, 182, 212, 0.2);
  font-size: 0.85rem;
  font-weight: 600;
  color: var(--accent-cyan);
}

.roadmap-arrow {
  color: var(--text-muted);
  font-size: 1.2rem;
  font-weight: 800;
}

/* ===== TOPICS STRUCTURE ===== */
.topic-section {
  margin-bottom: 72px;
  scroll-margin-top: calc(var(--navbar-height) + 24px);
}

.topic-header {
  margin-bottom: 32px;
  border-bottom: 1px solid var(--border-color);
  padding-bottom: 18px;
}

.topic-number {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  width: 44px;
  height: 44px;
  background: linear-gradient(135deg, #06b6d4, #9333ea);
  border-radius: 12px;
  font-weight: 800;
  font-size: 1.15rem;
  color: #fff;
  margin-bottom: 14px;
  box-shadow: 0 4px 10px rgba(6, 182, 212, 0.25);
}

.topic-header h2 {
  font-size: 1.95rem;
  font-weight: 850;
  margin-bottom: 8px;
  color: #fff;
}

.topic-header .topic-subtitle {
  color: var(--text-secondary);
  font-size: 1.05rem;
}

.section-block {
  margin-bottom: 36px;
}

.section-block h3 {
  font-size: 1.25rem;
  font-weight: 750;
  margin-bottom: 14px;
  display: flex;
  align-items: center;
  gap: 10px;
  color: var(--text-primary);
}

.section-block h4 {
  font-size: 1.05rem;
  font-weight: 650;
  margin: 20px 0 10px;
  color: var(--accent-cyan);
}

.section-block p, .section-block li {
  color: var(--text-secondary);
  font-size: 0.98rem;
  margin-bottom: 10px;
}

.section-block ul, .section-block ol {
  padding-left: 24px;
  margin-bottom: 14px;
}

.section-block ul li, .section-block ol li {
  margin-bottom: 6px;
}

/* Arabic Instruction Block */
.arabic {
  font-family: var(--font-arabic);
  direction: rtl;
  text-align: right;
  background: rgba(147, 51, 234, 0.05);
  border-right: 4px solid var(--accent-purple);
  padding: 18px 24px;
  border-radius: var(--radius-md);
  margin: 16px 0;
  line-height: 2;
  font-size: 1rem;
  color: var(--text-secondary);
  box-shadow: inset 0 0 10px rgba(0,0,0,0.1);
}

.arabic strong {
  color: #fff;
  font-weight: 700;
}

/* ===== SYNTAX HIGHLIGHTING CODE BLOCK ===== */
.code-block {
  position: relative;
  background: #090915;
  border: 1px solid var(--border-color);
  border-radius: var(--radius-md);
  margin: 20px 0;
  overflow: hidden;
}

.code-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 10px 18px;
  background: rgba(255, 255, 255, 0.02);
  border-bottom: 1px solid var(--border-color);
  font-size: 0.8rem;
}

.code-lang {
  color: var(--accent-cyan);
  font-weight: 650;
  letter-spacing: 0.5px;
}

.code-copy {
  background: var(--bg-glass);
  border: 1px solid var(--border-color);
  color: var(--text-secondary);
  padding: 5px 12px;
  border-radius: 6px;
  font-size: 0.74rem;
  cursor: pointer;
  transition: all 0.2s ease;
  font-family: var(--font-main);
}

.code-copy:hover {
  background: var(--accent-blue);
  color: #fff;
  border-color: var(--accent-blue);
}

.code-copy.copied {
  background: var(--accent-green);
  color: #fff;
  border-color: var(--accent-green);
}

pre {
  padding: 18px 24px;
  overflow-x: auto;
  font-family: var(--font-mono);
  font-size: 0.88rem;
  line-height: 1.75;
  color: #e6edf3;
}

.inline-code {
  background: rgba(6, 182, 212, 0.12);
  color: var(--accent-cyan);
  padding: 2px 7px;
  border-radius: 4px;
  font-size: 0.85em;
  font-family: var(--font-mono);
}

/* Code Syntax Colors */
.kw { color: #ff7b72; font-weight: 600; } /* Keyword */
.str { color: #a5d6ff; } /* String */
.cm { color: #8b949e; font-style: italic; } /* Comment */
.fn { color: #d2a8ff; } /* Function */
.mth { color: #06b6d4; } /* Method */
.num { color: #f2cc60; } /* Number */
.prop { color: #79c0ff; } /* Property */
.val { color: #ff7b72; } /* Value */
.sel { color: #ffa657; } /* Selector */

/* ===== CALLOUTS ===== */
.callout {
  border-radius: var(--radius-md);
  padding: 18px 22px;
  margin: 20px 0;
  border-left: 4px solid;
  display: flex;
  gap: 14px;
}

.callout-icon {
  font-size: 1.4rem;
  flex-shrink: 0;
  line-height: 1;
}

.callout-content {
  flex: 1;
}

.callout-title {
  font-weight: 750;
  font-size: 0.95rem;
  margin-bottom: 6px;
}

.callout-body {
  font-size: 0.9rem;
  color: var(--text-secondary);
  line-height: 1.6;
}

.callout.tip {
  background: rgba(16, 185, 129, 0.06);
  border-color: var(--accent-green);
}
.callout.tip .callout-icon, .callout.tip .callout-title {
  color: var(--accent-green);
}

.callout.warning {
  background: rgba(245, 158, 11, 0.06);
  border-color: var(--accent-orange);
}
.callout.warning .callout-icon, .callout.warning .callout-title {
  color: var(--accent-orange);
}

.callout.danger {
  background: rgba(239, 68, 68, 0.06);
  border-color: var(--accent-red);
}
.callout.danger .callout-icon, .callout.danger .callout-title {
  color: var(--accent-red);
}

.callout.info {
  background: rgba(6, 182, 212, 0.06);
  border-color: var(--accent-cyan);
}
.callout.info .callout-icon, .callout.info .callout-title {
  color: var(--accent-cyan);
}

/* ===== CARDS & GRID ===== */
.card {
  background: var(--bg-glass);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-lg);
  padding: 26px;
  margin: 16px 0;
  transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
}

.card:hover {
  background: var(--bg-glass-hover);
  transform: translateY(-3px);
  box-shadow: var(--shadow-glow);
  border-color: rgba(79, 70, 229, 0.3);
}

.card h4 {
  font-size: 1.05rem;
  font-weight: 750;
  margin-bottom: 10px;
  color: #fff;
}

.card-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
  gap: 20px;
  margin: 20px 0;
}

.card-grid .card {
  margin: 0;
}

/* ===== INTERACTIVE QUIZZES ===== */
.quiz {
  background: rgba(17, 17, 43, 0.5);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-lg);
  padding: 28px;
  margin: 24px 0;
}

.quiz-header {
  display: flex;
  align-items: center;
  gap: 10px;
  margin-bottom: 18px;
  font-weight: 800;
  color: var(--accent-cyan);
  font-size: 1.05rem;
}

.quiz-question {
  padding: 16px 0;
  border-bottom: 1px solid var(--border-color);
}

.quiz-question:last-child {
  border: none;
}

.quiz-q {
  font-weight: 650;
  margin-bottom: 12px;
  color: #fff;
  font-size: 0.98rem;
  line-height: 1.5;
}

.quiz-q .ar-q {
  display: block;
  font-family: var(--font-arabic);
  font-size: 0.9rem;
  color: var(--text-secondary);
  direction: rtl;
  text-align: right;
  margin-top: 6px;
}

.quiz-options {
  display: grid;
  grid-template-columns: 1fr;
  gap: 8px;
  margin-top: 10px;
}

.quiz-option {
  padding: 12px 18px;
  border-radius: var(--radius-md);
  font-size: 0.88rem;
  cursor: pointer;
  transition: all 0.2s ease;
  color: var(--text-secondary);
  background: rgba(255, 255, 255, 0.02);
  border: 1px solid var(--border-color);
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.quiz-option:hover {
  background: var(--bg-glass-hover);
  color: #fff;
  border-color: var(--border-glass);
}

.quiz-option.correct {
  background: rgba(16, 185, 129, 0.15) !important;
  color: var(--accent-green) !important;
  border-color: rgba(16, 185, 129, 0.4) !important;
  font-weight: 600;
}

.quiz-option.wrong {
  background: rgba(239, 68, 68, 0.15) !important;
  color: var(--accent-red) !important;
  border-color: rgba(239, 68, 68, 0.4) !important;
}

/* ===== COLLAPSIBLE ACCORDION (EXERCISES & ANSWERS) ===== */
.collapsible {
  margin: 14px 0;
  border: 1px solid var(--border-color);
  border-radius: var(--radius-md);
  overflow: hidden;
  background: rgba(255,255,255,0.01);
}

.collapsible-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 16px 22px;
  background: var(--bg-glass);
  cursor: pointer;
  font-weight: 600;
  font-size: 0.95rem;
  transition: all 0.25s ease;
  color: #fff;
}

.collapsible-header:hover {
  background: var(--bg-glass-hover);
}

.collapsible-header .arrow {
  transition: transform 0.3s ease;
  font-size: 0.8rem;
  color: var(--text-muted);
}

.collapsible.open {
  border-color: var(--border-glass);
}

.collapsible.open .collapsible-header {
  background: rgba(79, 70, 229, 0.08);
  border-bottom: 1px solid var(--border-color);
}

.collapsible.open .collapsible-header .arrow {
  transform: rotate(180deg);
  color: var(--accent-cyan);
}

.collapsible-body {
  max-height: 0;
  overflow: hidden;
  transition: max-height 0.4s cubic-bezier(0.4, 0, 0.2, 1);
  padding: 0 22px;
  background: rgba(0, 0, 0, 0.15);
}

.collapsible.open .collapsible-body {
  max-height: 2000px;
  padding: 20px 22px;
}

/* ===== TABLES ===== */
.table-wrapper {
  overflow-x: auto;
  margin: 24px 0;
  border-radius: var(--radius-md);
  border: 1px solid var(--border-color);
}

table {
  width: 100%;
  border-collapse: collapse;
  font-size: 0.9rem;
  text-align: left;
}

th {
  background: rgba(6, 182, 212, 0.08);
  padding: 14px 18px;
  font-weight: 700;
  color: var(--accent-cyan);
  border-bottom: 1px solid var(--border-color);
}

td {
  padding: 12px 18px;
  border-bottom: 1px solid var(--border-color);
  color: var(--text-secondary);
  vertical-align: top;
}

tr:last-child td {
  border: none;
}

tr:hover td {
  background: rgba(255, 255, 255, 0.02);
  color: #fff;
}

/* ===== CHEAT SHEET ===== */
.cheat-sheet {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
  gap: 20px;
  margin: 24px 0;
}

.cheat-item {
  background: rgba(17, 17, 43, 0.6);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-lg);
  padding: 22px;
  box-shadow: 0 4px 12px rgba(0, 0, 0, 0.2);
}

.cheat-item h5 {
  color: var(--accent-cyan);
  font-size: 0.98rem;
  margin-bottom: 12px;
  font-weight: 750;
  border-bottom: 1px solid var(--border-color);
  padding-bottom: 6px;
}

.cheat-item ul {
  list-style: none;
  padding: 0;
}

.cheat-item li {
  margin-bottom: 10px;
  font-size: 0.88rem;
}

.cheat-item code {
  font-family: var(--font-mono);
  font-size: 0.82rem;
  color: var(--accent-pink);
  background: rgba(219, 39, 119, 0.08);
  padding: 2px 6px;
  border-radius: 4px;
  display: inline-block;
  margin-bottom: 4px;
}

.cheat-item span {
  display: block;
  color: var(--text-secondary);
  font-size: 0.85rem;
}

/* ===== INTERACTIVE PLAYGROUND / SANDBOXES ===== */
.sandbox {
  background: rgba(10, 10, 26, 0.7);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-lg);
  padding: 24px;
  margin: 20px 0;
  box-shadow: var(--shadow-glow-cyan);
}

.sandbox-title {
  font-size: 1rem;
  font-weight: 700;
  color: var(--accent-cyan);
  margin-bottom: 16px;
  display: flex;
  align-items: center;
  gap: 8px;
}

/* Flexbox Sandbox specific styling */
.flex-sandbox-container {
  display: flex;
  background: rgba(255, 255, 255, 0.03);
  border: 2px dashed var(--border-glass);
  border-radius: var(--radius-md);
  padding: 20px;
  min-height: 220px;
  gap: 15px;
  align-items: stretch;
  margin-bottom: 20px;
  overflow-x: auto;
}

.flex-sandbox-item {
  background: linear-gradient(135deg, rgba(79, 70, 229, 0.25), rgba(147, 51, 234, 0.25));
  border: 2px solid var(--accent-blue);
  border-radius: var(--radius-sm);
  padding: 15px;
  color: #fff;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  min-width: 100px;
  text-align: center;
  transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
  position: relative;
}

.flex-sandbox-item:nth-child(2) {
  background: linear-gradient(135deg, rgba(6, 182, 212, 0.25), rgba(16, 185, 129, 0.25));
  border-color: var(--accent-cyan);
}

.flex-sandbox-item:nth-child(3) {
  background: linear-gradient(135deg, rgba(219, 39, 119, 0.25), rgba(245, 158, 11, 0.25));
  border-color: var(--accent-pink);
}

.flex-sandbox-item .item-label {
  font-weight: 800;
  font-size: 1.1rem;
  margin-bottom: 8px;
}

.flex-sandbox-item .item-details {
  font-family: var(--font-mono);
  font-size: 0.72rem;
  color: var(--text-secondary);
  line-height: 1.4;
  text-align: left;
}

.flex-controls-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(260px, 1fr));
  gap: 16px;
}

.flex-control-card {
  background: rgba(255, 255, 255, 0.02);
  border: 1px solid var(--border-color);
  border-radius: var(--radius-md);
  padding: 16px;
}

.flex-control-card h5 {
  font-size: 0.9rem;
  color: #fff;
  margin-bottom: 12px;
  display: flex;
  align-items: center;
  gap: 6px;
}

.control-group {
  margin-bottom: 10px;
  display: flex;
  flex-direction: column;
  gap: 4px;
}

.control-group:last-child {
  margin-bottom: 0;
}

.control-group label {
  font-size: 0.75rem;
  color: var(--text-secondary);
  display: flex;
  justify-content: space-between;
}

.control-group label span {
  font-family: var(--font-mono);
  color: var(--accent-cyan);
}

.control-group input[type="range"] {
  width: 100%;
  accent-color: var(--accent-cyan);
  background: rgba(255,255,255,0.1);
  height: 6px;
  border-radius: 3px;
  outline: none;
}

.control-group input[type="text"] {
  background: rgba(255,255,255,0.05);
  border: 1px solid var(--border-color);
  border-radius: 4px;
  padding: 6px 10px;
  color: #fff;
  font-family: var(--font-mono);
  font-size: 0.8rem;
  outline: none;
}
.control-group input[type="text"]:focus {
  border-color: var(--accent-blue);
}

/* Hiding Sandbox styling */
.hide-sandbox-container {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 16px;
  background: rgba(255,255,255,0.02);
  border: 1px solid var(--border-color);
  border-radius: var(--radius-md);
  padding: 24px;
  margin-bottom: 16px;
  min-height: 120px;
}

.hide-sandbox-item {
  background: rgba(79, 70, 229, 0.15);
  border: 1px solid var(--accent-blue);
  border-radius: var(--radius-md);
  padding: 20px;
  text-align: center;
  color: #fff;
  font-weight: 600;
  transition: all 0.5s ease;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: 8px;
}

.hide-sandbox-item.target {
  background: rgba(236, 72, 153, 0.2);
  border-color: var(--accent-pink);
  box-shadow: 0 0 15px rgba(236, 72, 153, 0.25);
}

/* States of the target item */
.hide-display-none {
  display: none !important;
}

.hide-visibility-hidden {
  visibility: hidden !important;
}

.hide-opacity-0 {
  opacity: 0 !important;
}

.hide-pointer-events-none {
  pointer-events: none !important;
  background: rgba(255, 255, 255, 0.05) !important;
  border-style: dotted !important;
}

.hide-btn-group {
  display: flex;
  flex-wrap: wrap;
  gap: 8px;
  margin-bottom: 16px;
}

.hide-btn {
  background: var(--bg-glass);
  border: 1px solid var(--border-color);
  color: var(--text-secondary);
  padding: 8px 16px;
  border-radius: var(--radius-sm);
  font-size: 0.85rem;
  cursor: pointer;
  font-weight: 550;
  transition: all 0.2s ease;
}

.hide-btn:hover, .hide-btn.active {
  background: var(--accent-pink);
  color: #fff;
  border-color: var(--accent-pink);
  box-shadow: 0 2px 10px rgba(236, 72, 153, 0.3);
}

.hide-sandbox-output {
  background: #090915;
  padding: 12px 16px;
  border-radius: var(--radius-sm);
  font-family: var(--font-mono);
  font-size: 0.8rem;
  color: var(--text-secondary);
  border-left: 3px solid var(--accent-pink);
}

/* Pseudo Elements Live Demos styles */
.pseudo-demo-card {
  max-width: 380px;
  margin: 30px auto;
  background: rgba(17,17,43,0.8);
  border: 1px solid var(--border-glass);
  border-radius: var(--radius-lg);
  padding: 30px;
  text-align: center;
  position: relative;
  overflow: hidden;
  box-shadow: var(--shadow-glow);
}

/* Overlay card example */
.pseudo-overlay-card {
  position: relative;
  border-radius: var(--radius-md);
  overflow: hidden;
  height: 250px;
  background-image: linear-gradient(rgba(0,0,0,0.1), rgba(0,0,0,0.1)), url('https://images.unsplash.com/photo-1579783900882-c0d3dad7b119?w=500&auto=format&fit=crop&q=60');
  background-size: cover;
  background-position: center;
  display: flex;
  align-items: flex-end;
  padding: 20px;
  margin-top: 15px;
}

/* The overlay via pseudo element */
.pseudo-overlay-card::before {
  content: '';
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: linear-gradient(to top, rgba(10, 10, 28, 0.95) 0%, rgba(10, 10, 28, 0.4) 50%, rgba(10, 10, 28, 0) 100%);
  transition: opacity 0.4s ease;
  z-index: 1;
}

.pseudo-overlay-card:hover::before {
  background: linear-gradient(to top, rgba(147, 51, 234, 0.9) 0%, rgba(79, 70, 229, 0.4) 60%, rgba(0, 0, 0, 0) 100%);
}

.pseudo-overlay-card-content {
  position: relative;
  z-index: 2;
  color: #fff;
}

.pseudo-overlay-card-content h4 {
  font-size: 1.15rem;
  margin-bottom: 4px;
}

/* Tooltip example style */
.tooltip-trigger {
  position: relative;
  display: inline-block;
  color: var(--accent-cyan);
  border-bottom: 1px dotted var(--accent-cyan);
  cursor: help;
  font-weight: 600;
  margin: 10px 0;
}

.tooltip-trigger::after {
  content: attr(data-tooltip);
  position: absolute;
  bottom: 130%;
  left: 50%;
  transform: translateX(-50%) scale(0.8);
  background: #11112b;
  border: 1px solid var(--border-glass);
  color: #fff;
  padding: 6px 12px;
  border-radius: var(--radius-sm);
  font-size: 0.78rem;
  white-space: nowrap;
  opacity: 0;
  pointer-events: none;
  transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
  box-shadow: 0 4px 15px rgba(0,0,0,0.5);
  z-index: 10;
}

.tooltip-trigger::before {
  content: '';
  position: absolute;
  bottom: 110%;
  left: 50%;
  transform: translateX(-50%) scale(0.8);
  border-width: 6px;
  border-style: solid;
  border-color: #11112b transparent transparent transparent;
  opacity: 0;
  pointer-events: none;
  transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
  z-index: 10;
}

.tooltip-trigger:hover::after, .tooltip-trigger:hover::before {
  opacity: 1;
  transform: translateX(-50%) scale(1);
}

/* Heading line effect */
.pseudo-heading {
  position: relative;
  display: inline-block;
  margin-bottom: 20px;
}

.pseudo-heading::after {
  content: '';
  position: absolute;
  left: 0;
  bottom: -6px;
  width: 50px;
  height: 3px;
  background: var(--gradient-primary);
  border-radius: 2px;
  transition: width 0.3s ease;
}

.pseudo-heading:hover::after {
  width: 100%;
}

/* Badge Style pseudo example */
.badge-demo {
  position: relative;
  padding: 10px 20px;
  background: rgba(255,255,255,0.05);
  border-radius: var(--radius-sm);
  display: inline-block;
  font-weight: 550;
  margin-top: 10px;
}
.badge-demo::after {
  content: 'NEW';
  position: absolute;
  top: -8px;
  right: -10px;
  background: var(--accent-pink);
  color: #fff;
  font-size: 0.65rem;
  font-weight: 800;
  padding: 2px 6px;
  border-radius: 10px;
  border: 2px solid var(--bg-primary);
  box-shadow: 0 2px 6px rgba(219,39,119,0.4);
}

/* Underline link effects */
.hover-underline-link {
  position: relative;
  color: var(--accent-purple);
  font-weight: 600;
}
.hover-underline-link::after {
  content: '';
  position: absolute;
  width: 100%;
  transform: scaleX(0);
  height: 2px;
  bottom: -2px;
  left: 0;
  background-color: var(--accent-purple);
  transform-origin: bottom right;
  transition: transform 0.25s ease-out;
}
.hover-underline-link:hover::after {
  transform: scaleX(1);
  transform-origin: bottom left;
}

/* Pseudo element fully styled Card Component */
.decorated-card {
  position: relative;
  background: var(--bg-secondary);
  border-radius: var(--radius-lg);
  padding: 32px;
  border: 1px solid var(--border-color);
  overflow: hidden;
  margin: 30px auto;
  max-width: 420px;
  z-index: 1;
}

/* Glowing top border design */
.decorated-card::before {
  content: '';
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 4px;
  background: var(--gradient-primary);
}

/* Floating orb graphic behind card contents */
.decorated-card::after {
  content: '';
  position: absolute;
  top: -80px;
  right: -80px;
  width: 160px;
  height: 160px;
  background: radial-gradient(circle, rgba(147, 51, 234, 0.2), transparent 70%);
  border-radius: 50%;
  z-index: -1;
  transition: transform 0.6s cubic-bezier(0.34, 1.56, 0.64, 1);
}

.decorated-card:hover::after {
  transform: scale(1.4) translate(-20px, 20px);
}

.decorated-card h4 {
  font-size: 1.25rem;
  margin-bottom: 12px;
  display: flex;
  align-items: center;
  gap: 8px;
}

.decorated-card p {
  font-size: 0.9rem;
  color: var(--text-secondary);
  margin-bottom: 20px;
}

.decorated-card-btn {
  position: relative;
  display: inline-block;
  background: transparent;
  color: #fff;
  border: 1px solid var(--accent-cyan);
  padding: 10px 24px;
  border-radius: var(--radius-sm);
  font-size: 0.88rem;
  font-weight: 600;
  cursor: pointer;
  overflow: hidden;
  z-index: 1;
  transition: color 0.4s ease;
}

/* Sliding background inside button via pseudo-element */
.decorated-card-btn::before {
  content: '';
  position: absolute;
  top: 0;
  left: -100%;
  width: 100%;
  height: 100%;
  background: var(--accent-cyan);
  z-index: -1;
  transition: left 0.35s cubic-bezier(0.4, 0, 0.2, 1);
}

.decorated-card-btn:hover {
  color: var(--bg-primary);
}

.decorated-card-btn:hover::before {
  left: 0;
}

/* Background Topic Interactive Demo Styles */
.bg-sandbox-container {
  border-radius: var(--radius-md);
  height: 250px;
  border: 1px solid var(--border-glass);
  position: relative;
  margin-bottom: 16px;
  transition: all 0.3s ease;
  display: flex;
  align-items: center;
  justify-content: center;
}

.bg-sandbox-overlay-text {
  background: rgba(10, 10, 26, 0.75);
  backdrop-filter: blur(5px);
  padding: 12px 20px;
  border-radius: var(--radius-sm);
  border: 1px solid var(--border-color);
  font-family: var(--font-mono);
  font-size: 0.82rem;
  text-align: center;
  color: #fff;
}

.object-fit-container {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 16px;
  margin-top: 16px;
}

.object-fit-box {
  background: rgba(255,255,255,0.02);
  border: 1px solid var(--border-color);
  border-radius: var(--radius-md);
  padding: 14px;
  text-align: center;
}

.object-fit-box h5 {
  font-size: 0.85rem;
  margin-bottom: 8px;
  color: var(--text-secondary);
}

.object-fit-img {
  width: 100%;
  height: 150px;
  border-radius: var(--radius-sm);
  background: rgba(0,0,0,0.3);
  display: block;
}

/* Beautiful Hero Section Design (Topic 4 Demo) */
.demo-hero {
  position: relative;
  border-radius: var(--radius-xl);
  overflow: hidden;
  padding: 80px 48px;
  text-align: center;
  background-image: linear-gradient(135deg, rgba(10,10,26,0.92) 20%, rgba(79,70,229,0.3) 100%), url('https://images.unsplash.com/photo-1550751827-4bd374c3f58b?w=1000&auto=format&fit=crop&q=80');
  background-size: cover;
  background-position: center;
  background-attachment: scroll;
  border: 1px solid var(--border-glass);
  box-shadow: var(--shadow-glow);
  margin-top: 24px;
}

.demo-hero-content {
  max-width: 600px;
  margin: 0 auto;
  position: relative;
  z-index: 2;
}

.demo-hero h3 {
  font-size: 2.2rem;
  font-weight: 900;
  margin-bottom: 14px;
  color: #fff;
}

.demo-hero p {
  color: var(--text-secondary);
  font-size: 1rem;
  margin-bottom: 24px;
}

.demo-hero-btn {
  display: inline-block;
  background: var(--gradient-primary);
  color: #fff;
  padding: 12px 30px;
  border-radius: 30px;
  font-weight: 700;
  box-shadow: 0 4px 15px rgba(147, 51, 234, 0.4);
  transition: transform 0.25s, box-shadow 0.25s;
}

.demo-hero-btn:hover {
  transform: translateY(-2px);
  box-shadow: 0 6px 20px rgba(147, 51, 234, 0.6);
  color: #fff;
}

/* Specificity Demo Styles */
.spec-box {
  padding: 12px 18px;
  border-radius: var(--radius-sm);
  background: rgba(255,255,255,0.03);
  margin-bottom: 8px;
  border-left: 3px solid var(--text-muted);
}
.spec-box.active {
  border-left-color: var(--accent-cyan);
  background: rgba(6, 182, 212, 0.05);
}

/* ===== MINI PROJECT: HEADPHONES PRODUCT LANDING PAGE ===== */
.project-wrapper {
  background: #080816;
  border-radius: var(--radius-xl);
  border: 1px solid var(--border-glass);
  overflow: hidden;
  box-shadow: 0 20px 50px rgba(0,0,0,0.6);
  margin: 40px 0;
  color: #fff;
}

/* CSS variables inside the project scope */
.project-wrapper {
  --p-accent: #00f2fe;
  --p-accent-purple: #4facfe;
  --p-gradient: linear-gradient(135deg, var(--p-accent-purple), var(--p-accent));
  --p-bg-card: rgba(255, 255, 255, 0.03);
}

.project-nav {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 20px 32px;
  border-bottom: 1px solid rgba(255, 255, 255, 0.06);
}

.project-logo {
  font-weight: 900;
  font-size: 1.25rem;
  letter-spacing: -0.5px;
  display: flex;
  align-items: center;
  gap: 8px;
}
.project-logo::before {
  content: '🎧';
}

.project-menu {
  display: flex;
  gap: 20px;
  list-style: none;
}
.project-menu a {
  color: #a2a2ca;
  font-size: 0.85rem;
  font-weight: 550;
}
.project-menu a:hover {
  color: var(--p-accent);
}

.project-hero {
  display: flex;
  flex-direction: row;
  align-items: center;
  padding: 60px 48px;
  gap: 40px;
}

@media(max-width: 768px) {
  .project-hero {
    flex-direction: column;
    text-align: center;
  }
}

.project-hero-content {
  flex: 1;
}

.project-hero-badge {
  display: inline-block;
  background: rgba(0, 242, 254, 0.12);
  color: var(--p-accent);
  padding: 4px 12px;
  border-radius: 12px;
  font-size: 0.72rem;
  font-weight: 700;
  margin-bottom: 16px;
  letter-spacing: 1px;
}

.project-hero h4 {
  font-size: 2.5rem;
  font-weight: 900;
  line-height: 1.2;
  margin-bottom: 14px;
  background: var(--p-gradient);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.project-hero p {
  color: #a2a2ca;
  font-size: 0.95rem;
  margin-bottom: 24px;
  line-height: 1.6;
}

.project-btn {
  background: var(--p-gradient);
  color: #080816;
  border: none;
  padding: 12px 28px;
  border-radius: 30px;
  font-weight: 800;
  font-size: 0.88rem;
  cursor: pointer;
  box-shadow: 0 4px 15px rgba(0, 242, 254, 0.3);
  transition: all 0.3s ease;
}
.project-btn:hover {
  transform: translateY(-2px);
  box-shadow: 0 6px 20px rgba(0, 242, 254, 0.5);
  opacity: 0.95;
}

.project-hero-media {
  flex: 1;
  display: flex;
  justify-content: center;
  align-items: center;
  position: relative;
}

.project-hero-media::before {
  content: '';
  position: absolute;
  width: 250px;
  height: 250px;
  background: radial-gradient(circle, rgba(0, 242, 254, 0.18), transparent 70%);
  border-radius: 50%;
  z-index: 1;
}

/* Image with Object Fit */
.project-img {
  width: 280px;
  height: 280px;
  object-fit: contain;
  position: relative;
  z-index: 2;
  animation: float 4s ease-in-out infinite;
}

@keyframes float {
  0%, 100% { transform: translateY(0); }
  50% { transform: translateY(-10px); }
}

/* Product grid section */
.project-section-title {
  text-align: center;
  padding: 0 20px;
  margin-bottom: 30px;
}
.project-section-title h5 {
  font-size: 1.4rem;
  font-weight: 800;
  margin-bottom: 6px;
}
.project-section-title p {
  color: #6b6b8b;
  font-size: 0.85rem;
}

.project-features {
  display: flex;
  padding: 0 48px 48px;
  gap: 20px;
  flex-wrap: wrap;
}

.project-card {
  flex: 1;
  min-width: 240px;
  background: var(--p-bg-card);
  border: 1px solid rgba(255,255,255,0.05);
  border-radius: var(--radius-lg);
  padding: 24px;
  text-align: left;
  transition: all 0.3s ease;
  position: relative;
  overflow: hidden;
}

/* Overlay hover effect */
.project-card::before {
  content: '';
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: linear-gradient(45deg, rgba(79, 70, 229, 0.08), rgba(0, 242, 254, 0.08));
  opacity: 0;
  transition: opacity 0.3s ease;
}

.project-card:hover {
  transform: translateY(-5px);
  border-color: rgba(0, 242, 254, 0.2);
}

.project-card:hover::before {
  opacity: 1;
}

.project-card-icon {
  font-size: 1.8rem;
  margin-bottom: 12px;
}

.project-card h6 {
  font-size: 1rem;
  font-weight: 700;
  margin-bottom: 6px;
}

.project-card p {
  color: #a2a2ca;
  font-size: 0.82rem;
  line-height: 1.5;
}

.project-footer {
  text-align: center;
  padding: 24px;
  border-top: 1px solid rgba(255, 255, 255, 0.06);
  font-size: 0.78rem;
  color: #6b6b8b;
}

/* ===== FOOTER ===== */
.footer {
  margin-top: 60px;
  padding: 40px 0 20px;
  border-top: 1px solid var(--border-color);
  text-align: center;
}

.footer p {
  color: var(--text-secondary);
  font-size: 0.9rem;
}

.footer a {
  color: var(--accent-cyan);
  font-weight: 600;
}

/* ===== ANIMATIONS ===== */
.animate-in {
  animation: fadeInUp 0.6s cubic-bezier(0.16, 1, 0.3, 1) both;
}

.delay-1 { animation-delay: 0.1s; }
.delay-2 { animation-delay: 0.2s; }
.delay-3 { animation-delay: 0.3s; }

@keyframes fadeInUp {
  from {
    opacity: 0;
    transform: translateY(20px);
  }
  to {
    opacity: 1;
    transform: translateY(0);
  }
}

/* ===== RESPONSIVE STYLING ===== */
@media (max-width: 1024px) {
  :root {
    --sidebar-width: 250px;
  }
  .main-content {
    padding: 36px;
  }
  .hero {
    padding: 36px;
  }
  .navbar-search {
    width: 240px;
  }
}

@media (max-width: 850px) {
  .hamburger {
    display: block;
  }
  
  .sidebar {
    transform: translateX(-100%);
    width: var(--sidebar-width);
  }
  
  .sidebar.open {
    transform: translateX(0);
  }
  
  .main-content {
    margin-left: 0;
    max-width: 100%;
    padding: 24px 20px;
  }
}

@media (max-width: 600px) {
  .navbar-search {
    display: none;
  }
  .hero h1 {
    font-size: 2.2rem;
  }
  .hero .subtitle {
    font-size: 1rem;
  }
  .instructor-card {
    flex-direction: column;
    text-align: center;
    padding: 24px;
  }
  .object-fit-container {
    grid-template-columns: 1fr;
  }
}
