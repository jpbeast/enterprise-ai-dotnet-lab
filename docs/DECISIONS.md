# Architecture Decisions and Trade-offs

Decisions must distinguish **accepted**, **proposed**, and **superseded** states.

## ADR-0001 — One evolving repository
- **Status:** Accepted
- **Context:** The learning series spans eight related technical milestones.
- **Decision:** Grow one public repository (`enterprise-ai-dotnet-lab`) rather than create one repository each week.
- **Consequences:** Easier to track architecture evolution and cross-cutting engineering decisions; requires discipline to avoid premature complexity.

## ADR-0002 — Incremental architecture
- **Status:** Accepted
- **Decision:** Start with a small runnable .NET application in Week 1. Add API, infrastructure, worker, MCP server, Aspire, test projects and other components only when their purpose is demonstrated.
- **Consequences:** Less setup overhead and clearer learning progression; refactoring may be needed later.

## ADR-0003 — Free/local first
- **Status:** Accepted as a cost policy; specific runtime/provider not yet selected.
- **Decision:** Evaluate local/free choices before cloud or paid services. Document why a paid resource is needed, billing requirements, charge triggers, budget settings and cleanup instructions first.
- **Consequences:** Cloud capabilities may require later experiments; local hardware constraints must be checked.

## Decision backlog
- Development machine capabilities and verified .NET SDK/IDE versions.
- Week 1 console app structure and testing framework.
- First AI model/provider and its configuration.
- Provider-swap comparison and measurement methodology.

For each new decision, record context, options considered, trade-offs, accepted choice, date and evidence.
